using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_polyclinic_Afonin_c_
{
    public partial class FindPattiens : Form
    {
        const string FILE_PATTIENS = "Pattiens.json";

        public FindPattiens()
        {
            InitializeComponent();
        }

        private void ButtonCloseFormFindPattien_Click(object sender, EventArgs e)
        {
            Close();
        }

        async private void ButtonFindPattien_Click(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxIll(textBoxFindIll)&&
                CheckOnCorrectTextBoxLastName(textBoxFindLastName)&&
                CheckOnCorrectTextBoxName(textBoxFindName))
            {
                var pattiens = await ReadFromFile<Pattiens>(FILE_PATTIENS);
                if (pattiens.Count == 0)
                {
                    Exception.MessageBox(0, "список пациентов пуст", "ошибка", 0);
                }
                else
                {
                    foreach (var pattien in pattiens)
                    {
                        if (pattien.Name==textBoxFindName.Text &&
                            pattien.LastName == textBoxFindLastName.Text &&
                            pattien.Disease == textBoxFindIll.Text)
                        {
                            MessageBox.Show(
                                $"Имя {pattien.Name}\n" +
                                $"Фамилия {pattien.LastName}\n" +
                                $"Возраст {pattien.Age}\n" +
                                $"Болезнь {pattien.Disease}", "Найденный пациент", 
                                0, MessageBoxIcon.Information);
                            break;
                        }
                        else
                        {
                            Exception.MessageBox(0, $"пациента с именем {textBoxFindName.Text},\n" +
                                $"фамилией{textBoxFindLastName.Text} и болезнью {textBoxFindIll.Text} не существует",
                                "ошибка", 0);
                            break;
                        }
                    }
                }
            }
            else
            {
                Exception.MessageBox(0, "некорректные данные, только символы кириллицы\n" +
                    "проверьте введенные значения", "ошибка", 0);
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

        bool CheckOnCorrectTextBoxName(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
           Regex.IsMatch(tb.Text, @"^[А-Яа-яЁё]+$")
           || (tb.BackColor = Color.MistyRose) != Color.MistyRose
           || (labelFindPattienName.Text = "Примеры ввода: Максим, Игорь") != "Примеры ввода: Максим, Игорь";

        bool CheckOnCorrectTextBoxLastName(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-Яа-яЁё]+$")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelFindPattienLastName.Text = "Примеры ввода: Петров, Иванов") != "Примеры ввода: Петров, Иванов";

        bool CheckOnCorrectTextBoxIll(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
           Regex.IsMatch(tb.Text, @"^[А-Яа-яЁё]+$")
           || (tb.BackColor = Color.MistyRose) != Color.MistyRose
           || (labelFindPattienIll.Text = "Примеры ввода: грипп, простуда") != "Примеры ввода: грипп, простуда";

        void Control_Click(object sender, EventArgs e)
        {
            labelFindPattienLastName.Text = "";
            labelFindPattienIll.Text = "";
            labelFindPattienName.Text = "";
            (sender as Control).BackColor = Color.WhiteSmoke;

        }

        private void FindPattiens_Load(object sender, EventArgs e)
        {

        }
    }
}
