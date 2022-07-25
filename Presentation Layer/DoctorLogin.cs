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
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void DoctorLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (loginUsernameTextBox.Text == "" && loginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Username and password cannot be empty");
            }
            else if (loginUsernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (loginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else
            {
                DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
                if (doctorDataAccess.ValidateLogin(loginUsernameTextBox.Text, loginPasswordTextBox.Text))
                {
                    DoctorMenu doctorMenu = new DoctorMenu();
                    doctorMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DoctorRegistration doctorRegistration = new DoctorRegistration();
            doctorRegistration.Show();
            this.Hide();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
