using Personal_Patient_Management_System_for_Doctors.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Patient_Management_System_for_Doctors.Data_Access_Layer
{
    class DoctorDataAccess : DataAccess
    {
        public bool UserRegister(DoctorData doctorData)
        {
            string sql = "INSERT INTO DoctorsData(DoctorName,DoctorUsername,DoctorPassword,DoctorEmail,DoctorDateOfBirth,DoctorGender,DoctorDegree) VALUES('" + doctorData.DoctorName + "','" + doctorData.DoctorUserName + "','" + doctorData.DoctorPassword + "','" + doctorData.DoctorEmail + "','" + doctorData.DoctorDateOfBirth + "','" + doctorData.DoctorGender + "','" + doctorData.DoctorDegree + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool ValidateLogin(string username, string password)
        {
            string sql = "SELECT * FROM DoctorsData WHERE DoctorUserName='" + username + "' AND DoctorPassword='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
                return true;
            else
                return false;
        }
    }
}
