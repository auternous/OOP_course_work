using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_polyclinic_Afonin_c_
{
    public partial class FormPattiens : Form
    {
        public static string NamePattienForm = "";
        public static string LastNamePattienForm="";
        public static int AgePattientForm=10;
        public static string DiseasePattienForm = "";


        public FormPattiens()
        {
            InitializeComponent();
        }

        public FormPattiens(string name, string lastName, int age, string ill)
        {
            InitializeComponent();
            buttonCreatePattien.Text = "Изменить поля пациента";
            NamePattienForm = name;
            LastNamePattienForm = lastName;
            AgePattientForm = age;
            DiseasePattienForm = ill;
            fillData();
        }
        private void fillData()
        {
            textNamePattien.Text = NamePattienForm;
            textLastNamePattien.Text = LastNamePattienForm;
            numericAgePattien.Value = AgePattientForm;

            textIllPatient.Text = DiseasePattienForm;

        }

        private void buttonCreatePattien_Click(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxName(textNamePattien)&&
                CheckOnCorrectTextBoxLastName(textLastNamePattien)&&

                CheckOnCorrectTextBoxIll(textIllPatient))

            {
                NamePattienForm=textNamePattien.Text;
                LastNamePattienForm=textLastNamePattien.Text;
                AgePattientForm=(int)numericAgePattien.Value;
                DiseasePattienForm = textIllPatient.Text;


                Close();
            }
            else
            {
                Exception.MessageBox(0, "некорректные данные, только символы кириллицы", "ошибка", 0);
            }
        }

        private void ButtonClosePattiensForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool CheckOnCorrectTextBoxName(TextBox tb) => !Regex.IsMatch(tb.Text,@"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-Я][а-я]*$") 
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose          
            || (labelHelpPattienName.Text = "Примеры ввода: Максим, Игорь") != "Примеры ввода: Максим, Игорь";
        
        bool CheckOnCorrectTextBoxLastName(TextBox tb) => !Regex.IsMatch(tb.Text,@"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-Я][а-я]*$") 
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose          
            || (labelHelpPattienLastName.Text = "Примеры ввода: Петров, Иванов") != "Примеры ввода: Петров, Иванов";






        bool CheckOnCorrectTextBoxIll(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-Яа-яЁё]+$")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelHelpPattienIll.Text = "Примеры ввода: грипп, простуда") != "Примеры ввода: грипп, простуда";



        private void FormPattiens_Load(object sender, EventArgs e)
        {

        }
    }
}
