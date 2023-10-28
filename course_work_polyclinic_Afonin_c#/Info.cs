using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_polyclinic_Afonin_c_
{
    public partial class Info : Form
    {
       
        
        public Info() => InitializeComponent();
        

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();

        }

        private void Info_Load(object sender, EventArgs e)
        {

        }
    }
}
