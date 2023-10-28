using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work_polyclinic_Afonin_c_
{
    public class Pattiens
    {
        public string Name { get; set; }  //имя
        public string LastName { get; set; }  //фамилия
        public int Age { get; set; } //возраст
        public string Disease { get; set; } //болезнь

        public Pattiens(string name, string lastName, int age,  string disease)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Disease = disease;

        }
    }
}
