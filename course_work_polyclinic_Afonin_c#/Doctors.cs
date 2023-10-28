using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work_polyclinic_Afonin_c_
{
    public class Doctors
    {
        public string Name { get; set; }  //имя
        public string LastName { get; set; }  //фамилия
        public string Specialization { get; set; } //специализация
        public int Age { get; set; } //возраст

        public Doctors(string name, string lastName, string specialization, int age) 
        {
            Name = name;
            LastName = lastName;
            Specialization = specialization;
            Age = age;
        }
    }
}
