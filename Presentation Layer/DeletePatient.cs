using Personal_Patient_Management_System_for_Doctors.Data_Access_Layer;
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
    public partial class DeletePatient : Form
    {
        public DeletePatient()
        {
            InitializeComponent();
        }

        private void DeletePatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AssistantMenu assistantMenu = new AssistantMenu();
            assistantMenu.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PatientDetailsDataAccess patientDetailsDataAccess = new PatientDetailsDataAccess();
            if (patientDetailsDataAccess.DeletePatient(Convert.ToInt32(deletePatientIdTextBox.Text)))
            {
                MessageBox.Show("Patient removeded");
                AssistantMenu assistantMenu = new AssistantMenu();
                assistantMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error in deleting");
            }



 
        }
    }
}
