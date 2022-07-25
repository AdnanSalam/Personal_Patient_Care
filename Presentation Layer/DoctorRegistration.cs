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
    public partial class DoctorRegistration : Form
    {
        public DoctorRegistration()
        {
            InitializeComponent();
        }

        private void DoctorRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

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

        private void Button4_Click(object sender, EventArgs e)
        {
            DoctorLogin doctorLogin = new DoctorLogin();
            doctorLogin.Show();
            this.Hide();
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
                //if(ValidateName(nameTextBox.Text) == true)
                //{
               //     MessageBox.Show("Name cannot contain number or special character");
                //}
                //else 
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else if(ValidatePassword(passwordTextBox.Text)==false)
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
                    DoctorData doctorData = new DoctorData();
                    doctorData.DoctorName = nameTextBox.Text;
                    doctorData.DoctorUserName = usernameTextBox.Text;
                    doctorData.DoctorPassword = passwordTextBox.Text;
                    doctorData.DoctorEmail = emailTextBox.Text;
                    doctorData.DoctorDateOfBirth = dateOfBirthDateTime.Text;
                    doctorData.DoctorDegree = degreeTextBox.Text;

                    if (maleRadioButton.Checked)
                    {
                        //gender = "Male";
                        doctorData.DoctorGender = "Male";
                    }
                    else
                        //gender = "Female";
                        doctorData.DoctorGender = "Female";
                    //bloodGroup = bloodGroupComboBox.Text;
                    
                    //Output output = new Output(name, username, password, email, dateOfBirth, gender, bloodGroup);
                    //Output output = new Output(user);


                    DoctorDataAccess doctorDataAccess = new DoctorDataAccess();

                    if (doctorDataAccess.UserRegister(doctorData))
                    {
                        MessageBox.Show("User added");
                        DoctorLogin doctorLogin = new DoctorLogin();
                        doctorLogin.Show();
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


    }
}
