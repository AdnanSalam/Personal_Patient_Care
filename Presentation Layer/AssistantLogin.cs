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
    public partial class AssistantLogin : Form
    {
        public AssistantLogin()
        {
            InitializeComponent();
        }

        private void AssistantLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
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
                AssistantDataAccess assistantDataAccess = new AssistantDataAccess();
                if (assistantDataAccess.ValidateAssistantLogin(loginUsernameTextBox.Text, loginPasswordTextBox.Text))
                {
                    AssistantMenu assistantMenu = new AssistantMenu();
                    assistantMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            AssistantRegistration assistantRegistration = new AssistantRegistration();
            assistantRegistration.Show();
            this.Hide();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
