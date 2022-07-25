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
    public partial class DoctorMenu : Form
    {
        public DoctorMenu()
        {
            InitializeComponent();
        }

        private void DoctorMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PatientDetails patientDetails = new PatientDetails();

            if (searchPatientIdTextBox.Text == "")
            {
                MessageBox.Show("Please give a Patient ID");
            }
            else
            {
                PatientDetailsDataAccess patientDetailsDataAccess = new PatientDetailsDataAccess();
                //int id = Convert.ToInt32(searchPatientIdTextBox.Text);
                //int id = Int32.Parse(searchPatientIdTextBox.Text);
                //PatientDetails patientDetails = patientDetailsDataAccess.CheckPatientId(Int32.Parse(searchPatientIdTextBox.Text));
                patientDetails = patientDetailsDataAccess.CheckPatientId(Int32.Parse(searchPatientIdTextBox.Text));
                //patientDetailsDataAccess.SId(Int32.Parse(searchPatientIdTextBox.Text));

                if (patientDetails == null)
                {

                    MessageBox.Show("Patient not available");
                    
                }
                else
                {
                    CheckPatient checkPatient = new CheckPatient(Int32.Parse(searchPatientIdTextBox.Text));
                    checkPatient.Show();
                    this.Hide();

                }

            }


        }

        private void PatientListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoctorMenu_Load(object sender, EventArgs e)
        {
            PatientDetailsDataAccess patientDetailsDataAccess = new PatientDetailsDataAccess();
            patientListGridView.DataSource = patientDetailsDataAccess.GetPatients();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            String input = searchPatientIdTextBox.Text;
            int result = 0;
            PatientDetailsDataAccess patientDetailsDataAccess = new PatientDetailsDataAccess();
            if (int.TryParse(input, out result))
            {
                if (searchPatientIdTextBox.Text == "")
                {
                    patientListGridView.DataSource = patientDetailsDataAccess.GetPatients();
                }
                else
                {
                    patientListGridView.DataSource = patientDetailsDataAccess.GetPatientById(Int32.Parse(searchPatientIdTextBox.Text));
                }
            }
            else
                patientListGridView.DataSource = patientDetailsDataAccess.GetPatients();
        }
    }
}
