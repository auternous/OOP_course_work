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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseMainForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPatiens_Click(object sender, EventArgs e)
        {
            PattiensAccountingForm pattiensAccountingForm = new PattiensAccountingForm();
            pattiensAccountingForm.ShowDialog();
        }

        private void FormDoctor_Click(object sender, EventArgs e)
        {
            DoctorAccountingForm doctorAccounting = new DoctorAccountingForm();
            doctorAccounting.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}