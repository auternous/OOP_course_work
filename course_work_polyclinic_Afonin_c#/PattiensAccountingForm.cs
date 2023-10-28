using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace course_work_polyclinic_Afonin_c_
{
    public partial class PattiensAccountingForm : Form
    {
        const string FILE_DOCTORS = "Doctors.json";
        const string FILE_PATTIENS = "Pattiens.json";

        int numberPattiens = 0;
        int countPattiens = 0;

        public PattiensAccountingForm()
        {
            Task.Run(() => File.Open(FILE_DOCTORS, FileMode.OpenOrCreate).Close());
            Task.Run(() => File.Open(FILE_PATTIENS, FileMode.OpenOrCreate).Close());

            InitializeComponent();
        }

        //запись в файл json
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }

        //чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }

        async private void ButtonCreatePattien_Click(object sender, EventArgs e)
        {
            FormPattiens formPatiens = new FormPattiens();
            formPatiens.ShowDialog();

            string namePattienForm = FormPattiens.NamePattienForm;
            string lastNamePattienForm = FormPattiens.LastNamePattienForm;
            int agePattienForm = FormPattiens.AgePattientForm;

            string diseasePattienForm = FormPattiens.DiseasePattienForm;


            Pattiens newPattien = new Pattiens(namePattienForm,lastNamePattienForm,agePattienForm,diseasePattienForm);

            if (!string.IsNullOrEmpty(namePattienForm) &&
                (agePattienForm > 0) &&
                !string.IsNullOrEmpty(lastNamePattienForm) &&

                !string.IsNullOrEmpty(diseasePattienForm))
            {
                var pattiens = await ReadFromFile<Pattiens>(FILE_PATTIENS);

                if (!pattiens.Contains(newPattien))
                {
                    foreach (var oldPattien in pattiens)
                    {
                        if (oldPattien.Name == namePattienForm &&
                            oldPattien.LastName == lastNamePattienForm &&
                            oldPattien.Age == agePattienForm &&
                            oldPattien.Disease == diseasePattienForm)
                        {
                            MessageBox.Show($"Пациент {oldPattien.Name} уже занесён в базу поликлиники. "
                                , "Добавление пациента", 0, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    pattiens.Add(newPattien);
                    countPattiens = pattiens.Count;
                    textBoxCountPattiens.Text = Convert.ToString(countPattiens);


                    await WriteToFile(pattiens, FILE_PATTIENS);

                    dataGridViewPattiens.Rows.Add();
                    dataGridViewPattiens.Rows[numberPattiens].Cells[0].Value = namePattienForm;
                    dataGridViewPattiens.Rows[numberPattiens].Cells[1].Value = lastNamePattienForm;
                    dataGridViewPattiens.Rows[numberPattiens].Cells[2].Value = agePattienForm;
                    dataGridViewPattiens.Rows[numberPattiens].Cells[3].Value = diseasePattienForm;


                    numberPattiens++;   
                }
                else
                {
                    MessageBox.Show($"Этот пациент был занесён в базу поликлиники ранее", "Добавление пациента", 0,
                        MessageBoxIcon.Information);
                    return;
                }
            }
        }

        async private void PattiensAccountingForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_PATTIENS))
            {

                var tableOfPattiens = await ReadFromFile<Pattiens>(FILE_PATTIENS);

                countPattiens = tableOfPattiens.Count;
                textBoxCountPattiens.Text = Convert.ToString(countPattiens);

                if (tableOfPattiens != null)

                    foreach (var pattien in tableOfPattiens)
                    {
                        dataGridViewPattiens.Rows.Add();
                        dataGridViewPattiens.Rows[numberPattiens].Cells[0].Value = pattien.Name;
                        dataGridViewPattiens.Rows[numberPattiens].Cells[1].Value = pattien.LastName;
                        dataGridViewPattiens.Rows[numberPattiens].Cells[2].Value = pattien.Age;
                        dataGridViewPattiens.Rows[numberPattiens].Cells[3].Value = pattien.Disease;

                        numberPattiens++;
                    }   
            }
        }

        async private void ButtonDeleteAllPattiens_Click(object sender, EventArgs e)
        {
            var pattiens = await ReadFromFile<Pattiens>(FILE_PATTIENS);
            countPattiens = pattiens.Count;
            if (countPattiens == 0)
            {
                MessageBox.Show("Нет ни одного пациента!", "Удалить всех пациентов", 0, MessageBoxIcon.Information);
                return;
            }
            else
            {
                pattiens.Clear();
                textBoxCountPattiens.Text = pattiens.Count.ToString();
                dataGridViewPattiens.Rows.Clear();
                numberPattiens = 0;
                MessageBox.Show("Данные всех пациентов удалены!", "Удалить всех пациентов", 0, MessageBoxIcon.Information);
            }
            await WriteToFile(pattiens, FILE_PATTIENS);
        }

        async private void ButtonDeleteSelectedPattien_Click(object sender, EventArgs e)
        {
            int selectCount = dataGridViewPattiens.GetCellCount(DataGridViewElementStates.Selected);

            if (selectCount > 0 && dataGridViewPattiens.CurrentCell.Value != null)
            {
                var pattiens = await ReadFromFile<Pattiens>(FILE_PATTIENS);

                string name = dataGridViewPattiens.SelectedCells[0].Value.ToString();
                string lastName = dataGridViewPattiens.SelectedCells[1].Value.ToString();
                int age = Convert.ToInt32(dataGridViewPattiens.SelectedCells[2].Value.ToString());
                string disease = dataGridViewPattiens.SelectedCells[3].Value.ToString();


                foreach (var pattien in pattiens)
                {
                    if (name == pattien.Name && lastName == pattien.LastName && age == pattien.Age &&
                         disease == pattien.Disease)
                        
                    {
                        pattiens.Remove(pattien);
                        textBoxCountPattiens.Text = Convert.ToString(pattiens.Count);
                        dataGridViewPattiens.Rows.Remove(dataGridViewPattiens.CurrentRow);
                        dataGridViewPattiens.Refresh();
                        MessageBox.Show($"Пациент  {pattien.Name}  удалён!", "Удаление одного пациента", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(pattiens, FILE_PATTIENS);
            } 
            else
            {
                MessageBox.Show("Нет ни одного пациента или вы не выбрали пациента для удаленя!",
                    "Удаление", 0,MessageBoxIcon.Information);
                return;
            }
        }

        private void ButtonClosePattiensAccountingForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonFindPattien_Click(object sender, EventArgs e)
        {
            FindPattiens findPattien = new FindPattiens();
            findPattien.ShowDialog();
        }

        async private void ButtonAnalysePattiens_Click(object sender, EventArgs e)
        {
            var pattiens = await ReadFromFile<Pattiens>(FILE_PATTIENS);
            Dictionary<string, int> patientsCountByDisease = new Dictionary<string, int>();

            foreach (var patient in pattiens)
            {
                if (!patientsCountByDisease.ContainsKey(patient.Disease))
                {
                    patientsCountByDisease[patient.Disease] = 0;
                }
                patientsCountByDisease[patient.Disease]++;
            }

            StringBuilder messageBuilder = new StringBuilder();
            foreach (var diseaseGroup in patientsCountByDisease)
            {
                messageBuilder.AppendLine($"{diseaseGroup.Key} - {diseaseGroup.Value}");
            }
            string message = messageBuilder.ToString();
            MessageBox.Show(message, "Пациенты с одинаковыми болезнями:");


        }

        private void textBoxSearchPattiens_TextChanged(object sender, EventArgs e)
        {
            dataGridViewPattiens.AllowUserToAddRows = false;
            string searchValue = textBoxSearchPattiens.Text;

            // Проверка выбранного индекса в comboBoxFilterPattiens
            if (comboBoxFilterPattiens.SelectedIndex == -1)
            {
                textBoxSearchPattiens.Text = "";
                MessageBox.Show("Выберите поле для фильтрации", "Предупреждение", 0, MessageBoxIcon.Information);
                return;
            }

            int columnIndex = comboBoxFilterPattiens.SelectedIndex;
            bool hasVisibleRows = false;

            foreach (DataGridViewRow row in dataGridViewPattiens.Rows)
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
                MessageBox.Show($"Нет записей с такими данными: {searchValue}", "Предупреждение", 0, MessageBoxIcon.Information);
            }

            dataGridViewPattiens.AllowUserToAddRows = true;
        }

        async private void dataGridViewPattiens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewPattiens.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string lastName = selectedRow.Cells[1].Value.ToString();
            int age = Convert.ToInt32(selectedRow.Cells[2].Value);
            string ill = selectedRow.Cells[3].Value.ToString();

            FormPattiens formPatiens = new FormPattiens(name, lastName, age, ill);
            formPatiens.ShowDialog();

            string namePattienForm = FormPattiens.NamePattienForm;
            string lastNamePattienForm = FormPattiens.LastNamePattienForm;
            int agePattienForm = FormPattiens.AgePattientForm;
            string diseasePattienForm = FormPattiens.DiseasePattienForm;

            Pattiens modifiedPattien = new Pattiens(namePattienForm, lastNamePattienForm, agePattienForm, diseasePattienForm);

            var pattiens = await ReadFromFile<Pattiens>(FILE_PATTIENS);

            for (int i = 0; i < pattiens.Count; i++)
            {
                var pattien = pattiens[i];
                if (name == pattien.Name && lastName == pattien.LastName && age == pattien.Age && ill == pattien.Disease)
                {
                    if (name != namePattienForm || lastName != lastNamePattienForm || age != agePattienForm || ill != diseasePattienForm)
                    {
                        pattiens.RemoveAt(i);
                        pattiens.Add(modifiedPattien);
                        selectedRow.Cells[0].Value = namePattienForm;
                        selectedRow.Cells[1].Value = lastNamePattienForm;
                        selectedRow.Cells[2].Value = agePattienForm;
                        selectedRow.Cells[3].Value = diseasePattienForm;
                        dataGridViewPattiens.Refresh();
                        MessageBox.Show($"Данные пациента {pattien.Name} {pattien.LastName} изменены!", "Изменение данных пациента", 0, MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Данные пациента {pattien.Name} {pattien.LastName} не изменены!", "Изменение данных пациента", 0, MessageBoxIcon.Information);
                    }
                }
            }

            await WriteToFile(pattiens, FILE_PATTIENS);
        }

        private void ButtonResetFiltering_Click(object sender, EventArgs e)
        {
            textBoxSearchPattiens.Text = "";
            MessageBox.Show($"Фильтрация сброшена", "Внимание", 0, MessageBoxIcon.Information);
        }


    }
}
