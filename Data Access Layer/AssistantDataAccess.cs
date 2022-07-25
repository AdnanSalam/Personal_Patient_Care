using Personal_Patient_Management_System_for_Doctors.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Patient_Management_System_for_Doctors.Data_Access_Layer
{
    class AssistantDataAccess:DataAccess
    {
        public bool AssistantRegister(AssistantData assistantData)
        {
            string sql = "INSERT INTO AssistantsData(AssistantName,AssistantUserName,AssistantPassword,AssistantEmail,AssistantDateOfBirth,AssistantGender,AssistantDegree) VALUES('" + assistantData.AssistantName + "','" + assistantData.AssistantUserName + "','" + assistantData.AssistantPassword + "','" + assistantData.AssistantEmail + "','" + assistantData.AssistantDateOfBirth + "','" + assistantData.AssistantGender + "','" + assistantData.AssistantDegree + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool ValidateAssistantLogin(string username, string password)
        {
            string sql = "SELECT * FROM AssistantsData WHERE AssistantUserName='" + username + "' AND AssistantPassword='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
                return true;
            else
                return false;
        }
    }
}
