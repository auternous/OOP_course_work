using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_polyclinic_Afonin_c_
{
    public partial class DoctorAccountingForm : Form
    {
        const string FILE_DOCTORS = "Doctors.json";
        const string FILE_PATTIENS = "Pattiens.json";

        int numbersDoctors = 0;
        int countDoctors = 0;

        public DoctorAccountingForm()
        {
            Task.Run(() => File.Open(FILE_DOCTORS,FileMode.OpenOrCreate).Close());
            Task.Run(() => File.Open(FILE_PATTIENS,FileMode.OpenOrCreate).Close());

            InitializeComponent();
        }

        //запись в файл json
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() =>JsonConvert.SerializeObject(data)));
            }
        }

        //чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ??new List<T>());
            }
        }

        private void ButtonCloseDoctorAccounting_Click(object sender, EventArgs e)
        {
            Close();
        }

        async private void ButtonCreateDoctor_Click(object sender, EventArgs e)
        {
            FormDoctors formDoctor = new FormDoctors();
            formDoctor.ShowDialog();

            string nameDoctorForm = FormDoctors.NameDoctorForm;
            string lastNameDoctorForm = FormDoctors.LastNameDoctorForm;
            string specializationForm = FormDoctors.SpecializationForm;
            int ageDoctorForm = FormDoctors.AgeDoctorForm;

            Doctors newDoctor = new Doctors(nameDoctorForm,lastNameDoctorForm,specializationForm,ageDoctorForm);

            if (!string.IsNullOrEmpty(nameDoctorForm) && 
                (ageDoctorForm > 0) && 
                !string.IsNullOrEmpty(lastNameDoctorForm) && 
                !string.IsNullOrEmpty(specializationForm))
            {
                var doctors = await ReadFromFile<Doctors>(FILE_DOCTORS);

                if (!doctors.Contains(newDoctor))
                {
                    foreach (var oldDoctor in doctors)
                    {
                        if (oldDoctor.Name == nameDoctorForm && 
                            oldDoctor.LastName == lastNameDoctorForm &&
                            oldDoctor.Specialization == specializationForm &&
                            oldDoctor.Age == ageDoctorForm)
                        {
                            MessageBox.Show($"Доктор {oldDoctor.Name} уже занесён в базу поликлиники. "
                                , "Добавление доктора", 0,MessageBoxIcon.Information);
                            return;
                        }
                    }

                    doctors.Add(newDoctor);
                    countDoctors = doctors.Count;
                    textBoxCountDoctors.Text = Convert.ToString(countDoctors);


                    await WriteToFile(doctors, FILE_DOCTORS);

                    dataGridViewDoctors.Rows.Add();
                    dataGridViewDoctors.Rows[numbersDoctors].Cells[0].Value = nameDoctorForm;
                    dataGridViewDoctors.Rows[numbersDoctors].Cells[1].Value = lastNameDoctorForm;
                    dataGridViewDoctors.Rows[numbersDoctors].Cells[2].Value = ageDoctorForm;
                    dataGridViewDoctors.Rows[numbersDoctors].Cells[3].Value = specializationForm;
                    numbersDoctors++;
                }
                else
                {
                    MessageBox.Show($"Этот доктор был занесён в базу поликлиники ранее", "Добавление доктора", 0, 
                        MessageBoxIcon.Information);
                    return;
                }
            }
        }

        async private void DoctorAccountingForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_DOCTORS))
            {
                var tableOfDoctors = await ReadFromFile<Doctors>(FILE_DOCTORS);
                numbersDoctors = 0;
                countDoctors = tableOfDoctors.Count;
                textBoxCountDoctors.Text = Convert.ToString(countDoctors);

                if (tableOfDoctors != null)

                    foreach (var doctor in tableOfDoctors)
                    {
                        dataGridViewDoctors.Rows.Add();
                        dataGridViewDoctors.Rows[numbersDoctors].Cells[0].Value = doctor.Name;
                        dataGridViewDoctors.Rows[numbersDoctors].Cells[1].Value = doctor.LastName;
                        dataGridViewDoctors.Rows[numbersDoctors].Cells[2].Value = doctor.Age;
                        dataGridViewDoctors.Rows[numbersDoctors].Cells[3].Value = doctor.Specialization;
                        numbersDoctors++;
                    }
            }
        }

        async private void ButtonDeleteSelectedDoctor_Click(object sender, EventArgs e)
        {
            int selectCount = dataGridViewDoctors.GetCellCount(DataGridViewElementStates.Selected);

            if (selectCount > 0 && dataGridViewDoctors.CurrentCell.Value != null)
            {
                var doctors = await ReadFromFile<Doctors>(FILE_DOCTORS);

                string name = dataGridViewDoctors.SelectedCells[0].Value.ToString();
                string lastName = dataGridViewDoctors.SelectedCells[1].Value.ToString();
                int age = Convert.ToInt32(dataGridViewDoctors.SelectedCells[2].Value.ToString());
                string specialization = dataGridViewDoctors.SelectedCells[3].Value.ToString();

                foreach (var doctor in doctors)
                {
                    if (name == doctor.Name && lastName == doctor.LastName && age == doctor.Age &&
                        specialization == doctor.Specialization)
                    {
                        doctors.Remove(doctor);
                        textBoxCountDoctors.Text = Convert.ToString(doctors.Count);
                        dataGridViewDoctors.Rows.Remove(dataGridViewDoctors.CurrentRow);
                        dataGridViewDoctors.Refresh();
                        MessageBox.Show($"Доктор {doctor.Name}  удалён!", "Удаление одного доктора", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(doctors, FILE_DOCTORS);
            }
            else
            {
                MessageBox.Show("Нет ни одного доктора или вы не выбрали доктора для удаления!", 
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
    }

        async private void ButtonDeleteAllDoctor_Click(object sender, EventArgs e)
        {
            var doctors = await ReadFromFile<Doctors>(FILE_DOCTORS);
            countDoctors = doctors.Count;
            if (countDoctors == 0)
            {
                MessageBox.Show("Нет ни одного доктора!", "Удалить всех докторов", 0, MessageBoxIcon.Information);
                return;
            }
            else
            {
                doctors.Clear();
                textBoxCountDoctors.Text = doctors.Count.ToString();
                dataGridViewDoctors.Rows.Clear();
                numbersDoctors = 0;
                MessageBox.Show("Данные всех докторов удалены!", "Удалить всех докторов", 0, MessageBoxIcon.Information);
            }
            await WriteToFile(doctors, FILE_DOCTORS);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewDoctors.AllowUserToAddRows = false;
            string searchValue = textBoxSearchDoctor.Text;
            int columnIndex = comboBoxDoctor.SelectedIndex;
            bool hasVisibleRows = false;
            if (comboBoxDoctor.SelectedIndex == -1)
            {
                textBoxSearchDoctor.Text = "";
                MessageBox.Show($"Выберите поле по которому будет поизводиться фильтрация", "Внимание",
                    0, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewDoctors.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString().Contains(searchValue))
                    {
                        row.Visible = true;
                        hasVisibleRows = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                if (!hasVisibleRows)
                {
                    MessageBox.Show($"Полей с такими данными: {searchValue} - нет!", "Внимание", 0, MessageBoxIcon.Information);
                }
            }
            dataGridViewDoctors.AllowUserToAddRows = true;
        }

        private void ButtonResetFiltering_Click(object sender, EventArgs e)
        {
            textBoxSearchDoctor.Text = "";
            MessageBox.Show($"Фильтрация сброшена", "Внимание", 0, MessageBoxIcon.Information);
        }

        async private void dataGridViewDoctors_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewDoctors.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string lastName = selectedRow.Cells[1].Value.ToString();
            int age = Convert.ToInt32(selectedRow.Cells[2].Value);
            string specialization = selectedRow.Cells[3].Value.ToString();

            FormDoctors formDoctors = new FormDoctors(name, lastName, age, specialization);
            formDoctors.ShowDialog();

            string nameDoctor = FormDoctors.NameDoctorForm;
            string lastNameDoctor = FormDoctors.LastNameDoctorForm;
            string specialisation = FormDoctors.SpecializationForm;
            int ageDoctor = FormDoctors.AgeDoctorForm;

            Doctors modifiedDoctor = new Doctors(nameDoctor, lastNameDoctor, specialisation, ageDoctor);

            var doctors = await ReadFromFile<Doctors>(FILE_DOCTORS);

            for (int i = 0; i < doctors.Count; i++)
            {
                var doctor = doctors[i];
                if (name == doctor.Name && lastName == doctor.LastName && age == doctor.Age && specialisation == doctor.Specialization)
                {
                    if (name != nameDoctor || lastName != lastNameDoctor || age != ageDoctor || specialization != specialisation)
                    {
                        doctors.RemoveAt(i);
                        doctors.Add(modifiedDoctor);
                        selectedRow.Cells[0].Value = nameDoctor;
                        selectedRow.Cells[1].Value = lastNameDoctor;
                        selectedRow.Cells[2].Value = ageDoctor;
                        selectedRow.Cells[3].Value = specialisation;
                        dataGridViewDoctors.Refresh();
                        MessageBox.Show($"Данные доктора {doctor.Name} {doctor.LastName} изменены!", "Изменение данных доктора", 0, MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Данные доктора {doctor.Name} {doctor.LastName} не изменены!", "Изменение данных доктора", 0, MessageBoxIcon.Information);
                    }
                }
            }

            await WriteToFile(doctors, FILE_DOCTORS);
        }
    }
}
