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
    public partial class AssistantRegistration : Form
    {
        public AssistantRegistration()
        {
            InitializeComponent();
        }

        private void AssistantRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AssistantLogin assistantLogin = new AssistantLogin();
            assistantLogin.Show();
            this.Hide();
        }

        private void TermsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termsCheckBox.Checked == true)
            {
                submitButton.Enabled = true;
            }
            else
                submitButton.Enabled = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if (confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm Password cannot be empty");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (dateOfBirthDateTime.Text == "")
            {
                MessageBox.Show("Select a date");
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (degreeTextBox.Text == "")
            {
                MessageBox.Show("Gegree cannot be empty");
            }
            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else if (ValidatePassword(passwordTextBox.Text) == false)
                {
                    MessageBox.Show("Password must contain at least one lower case letter, one upper case letter, one special character, one number and at least 8 characters length");
                }
                else
                {
                    //string name, username, password, email, dateOfBirth, gender, bloodGroup;
                    //name = nameTextBox.Text;
                    //username = usernameTextBox.Text;
                    //password = passwordTextBox.Text;
                    //email = emailTextBox.Text;
                    //dateOfBirth = dateOfBirthDateTime.Text;
                    AssistantData assistantData = new AssistantData();
                    assistantData.AssistantName = nameTextBox.Text;
                    assistantData.AssistantUserName = usernameTextBox.Text;
                    assistantData.AssistantPassword = passwordTextBox.Text;
                    assistantData.AssistantEmail = emailTextBox.Text;
                    assistantData.AssistantDateOfBirth = dateOfBirthDateTime.Text;
                    assistantData.AssistantDegree = degreeTextBox.Text;
                    if (maleRadioButton.Checked)
                    {
                        //gender = "Male";
                        assistantData.AssistantGender = "Male";
                    }
                    else
                        //gender = "Female";
                        assistantData.AssistantGender = "Female";
                    //bloodGroup = bloodGroupComboBox.Text;

                    //Output output = new Output(name, username, password, email, dateOfBirth, gender, bloodGroup);
                    //Output output = new Output(user);


                    AssistantDataAccess assistantDataAccess = new AssistantDataAccess();

                    if (assistantDataAccess.AssistantRegister(assistantData))
                    {
                        MessageBox.Show("User added");
                        AssistantLogin assistantLogin = new AssistantLogin();
                        assistantLogin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error in adding");
                    }

                }
            }

            bool ValidatePassword(string passWord)
            {
                int validConditions = 0;
                foreach (char c in passWord)
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        validConditions++;
                        break;
                    }
                }
                foreach (char c in passWord)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        validConditions++;
                        break;
                    }
                }
                if (validConditions == 0) return false;
                foreach (char c in passWord)
                {
                    if (c >= '0' && c <= '9')
                    {
                        validConditions++;
                        break;
                    }
                }
                if (validConditions == 1) return false;
                if (validConditions == 2)
                {
                    char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' };
                    if (passWord.IndexOfAny(special) == -1) return false;
                }
                return true;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
