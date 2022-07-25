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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("Address cannot be empty");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (dateOfBirthDateTime.Text == "")
            {
                MessageBox.Show("Select a date");
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false && otherRadioButton.Checked == false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Select a blood group");
            }
            else if (weightTextBox.Text == "")
            {
                MessageBox.Show("Weight cannot be empty");
            }
            else if (heightTextBox.Text == "")
            {
                MessageBox.Show("Height cannot be empty");
            }
            else
            {
                PatientDetails patientDetails = new PatientDetails();
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
                //bloodGroup = bloodGroupComboBox.Text;

                //Output output = new Output(name, username, password, email, dateOfBirth, gender, bloodGroup);
                //Output output = new Output(user);


                PatientDetailsDataAccess patientDetailsDataAccess = new PatientDetailsDataAccess();

                    if (patientDetailsDataAccess.AddPatient(patientDetails))
                    {
                        MessageBox.Show("Patient Added");
                        AddPatient addPatient = new AddPatient();
                        addPatient.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error in Adding");
                    }

                }
            }

        private void Button2_Click(object sender, EventArgs e)
        {
            AssistantMenu assistantMenu = new AssistantMenu();
            assistantMenu.Show();
            this.Hide();
        }
    }
}
