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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DoctorLogin doctorLogin = new DoctorLogin();
            doctorLogin.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AssistantLogin assistantLogin = new AssistantLogin();
            assistantLogin.Show();
            this.Hide();
        }
    }
}
