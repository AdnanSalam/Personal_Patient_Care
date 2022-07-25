using Personal_Patient_Management_System_for_Doctors.Data_Access_Layer;
using Personal_Patient_Management_System_for_Doctors.Entities;
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
    public partial class UpdatePatient : Form
    {
        public UpdatePatient()
        {
            InitializeComponent();
        }

        private void UpdatePatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AssistantMenu assistantMenu = new AssistantMenu();
            assistantMenu.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PatientDetailsDataAccess patientDetailsDataAccess = new PatientDetailsDataAccess();
            //int categoryId = categoryDataAccess.GetCategoryByName(updateCategoryIdComboBox.Text).CategoryId;

            PatientDetails patientDetails = new PatientDetails();
            patientDetails.PatientId = Int32.Parse(idTextBox.Text) ;
            patientDetails.PatientName = nameTextBox.Text;
            patientDetails.PatientAddress = addressTextBox.Text;
            patientDetails.PatientHeight = Convert.ToDouble(heightTextBox.Text);
            patientDetails.PatientWeight = Convert.ToDouble(weightTextBox.Text);
            patientDetails.PatientEmail = emailTextBox.Text;
            patientDetails.PatientDateOfBirth = dateOfBirthDateTime.Text;
            patientDetails.PatientBloodGroup = bloodGroupComboBox.Text;

            if (maleRadioButton.Checked)
            {
                patientDetails.PatientGender = "Male";
            }
            else if (femaleRadioButton.Checked)
            {
                patientDetails.PatientGender = "Female";
            }
            else
                patientDetails.PatientGender = "Other";


            if (patientDetailsDataAccess.UpdatePatient(patientDetails))
            {
                MessageBox.Show("Patient Updateded");
                AssistantMenu assistantMenu = new AssistantMenu();
                assistantMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error in Adding");
            }

        }
    }
}
