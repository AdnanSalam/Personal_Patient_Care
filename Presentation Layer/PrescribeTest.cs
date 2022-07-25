using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Patient_Management_System_for_Doctors.Presentation_Layer
{
    public partial class PrescribeTest : Form
    {


        int PatientId;

        
        public PrescribeTest()
        {
            InitializeComponent();
        }
        public PrescribeTest(int PatientId)
        {
            this.PatientId = PatientId;
            InitializeComponent();
        }

        private void PrescribeTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CheckPatient checkPatient = new CheckPatient(this.PatientId);
            checkPatient.Show();
            this.Hide();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(rbsCheckBox.Checked)
            {
                
            }





        }

        private void HeamoglobinPCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
