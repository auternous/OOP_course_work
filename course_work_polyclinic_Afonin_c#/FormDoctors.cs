using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace course_work_polyclinic_Afonin_c_
{
    public partial class FormDoctors : Form
    {
        public static string NameDoctorForm = ""; 
        public static string LastNameDoctorForm = ""; 
        public static string SpecializationForm = "";
        public static int AgeDoctorForm = 0;

        public FormDoctors()
        {
            InitializeComponent();
        }

        public FormDoctors(string name, string lastName, int age, string specialization)
        {
            InitializeComponent();
            ButtonCreateDoctor.Text = "Изменить поля доктора";
            NameDoctorForm = name;
            LastNameDoctorForm = lastName;
            SpecializationForm = specialization;
            AgeDoctorForm = age;
            fillData();
        }

        private void fillData()
        {
            textNameDoctor.Text = NameDoctorForm;
            textLastNameDoctor.Text = LastNameDoctorForm;
            textSpecializationDoctor.Text = SpecializationForm;
            numericAgeDoctor.Value = AgeDoctorForm;
        }

        private void ButtonCloseFormDoctor_Click(object sender, EventArgs e)
        {
            NameDoctorForm = "";
            LastNameDoctorForm = "";
            AgeDoctorForm = 0;
            SpecializationForm = "";

            Close();
        }

        private void ButtonCreateDoctor_Click(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxName(textNameDoctor)&&
                CheckOnCorrectTextBoxLastName(textLastNameDoctor)&&
                CheckOnCorrectTextBoxSpecialisation(textSpecializationDoctor))
            {
                NameDoctorForm = textNameDoctor.Text;
                LastNameDoctorForm = textLastNameDoctor.Text;
                SpecializationForm = textSpecializationDoctor.Text;
                AgeDoctorForm = (int)numericAgeDoctor.Value;

                Close();
            }
            else
            {
                Exception.MessageBox(0, "некорректные данные, только символы кириллицы", "ошибка", 0);
            }

        }

        bool CheckOnCorrectTextBoxName(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-Я][а-я]*$")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelHelpDoctorName.Text = "Примеры ввода: Максим, Игорь") != "Примеры ввода: Максим, Игорь";

        bool CheckOnCorrectTextBoxLastName(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-Я][а-я]*$")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelHelpDoctorLastName.Text = "Примеры ввода: Петров, Иванов") != "Примеры ввода: Петров, Иванов";

        bool CheckOnCorrectTextBoxSpecialisation(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-Яа-яЁё]+$")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelHelpDoctorSpecialisation.Text = "Примеры ввода: лор, ортопед") != "Примеры ввода: лор, ортопед";

        private void FormDoctors_Load(object sender, EventArgs e)
        {

        }
    }
}
