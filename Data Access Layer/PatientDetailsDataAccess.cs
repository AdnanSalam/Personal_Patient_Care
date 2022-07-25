using Personal_Patient_Management_System_for_Doctors.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Patient_Management_System_for_Doctors.Data_Access_Layer
{
    class PatientDetailsDataAccess : DataAccess
    {

        public List<PatientDetails> GetPatients()
        {
            string sql = "SELECT * From PatientsDetails";
            SqlDataReader reader = this.GetData(sql);
            List<PatientDetails> patientsDetails = new List<PatientDetails>();
            while (reader.Read())
            {
                PatientDetails patientDetails = new PatientDetails();
                patientDetails.PatientId = (int)reader["PatientID"];
                patientDetails.PatientName = reader["PatientName"].ToString();
                patientDetails.PatientDateOfBirth = Convert.ToDateTime(reader["PatientDateOfBirth"]).ToString();
                patientDetails.PatientEmail = reader["PatientEmail"].ToString();
                patientDetails.PatientAddress = reader["PatientAddress"].ToString();
                patientDetails.PatientGender = reader["PatientGender"].ToString();
                patientDetails.PatientHeight = Convert.ToDouble(reader["PatientHeight"]);
                patientDetails.PatientWeight = Convert.ToDouble(reader["PatientWeight"]);
                patientDetails.PatientBloodGroup = reader["PatientBloodGroup"].ToString();

                patientsDetails.Add(patientDetails);

            }
            return patientsDetails;
        }

      //  public String PatientName { get; set; }
       // public String PatientDateOfBirth { get; set; }
       // public String PatientEmail { get; set; }
        //public String PatientAddress { get; set; }
       // public String PatientGender { get; set; }
       // public double PatientHeight { get; set; }
       // public double PatientWeight { get; set; }
       // public String PatientBloodGroup { get; set; }




        public bool AddPatient(PatientDetails patientDetails)
        {
            string sql = "INSERT INTO PatientsDetails(PatientName,PatientDateOfBirth,PatientEmail,PatientAddress,PatientGender,PatientHeight,PatientWeight,PatientBloodGroup) VALUES('" + patientDetails.PatientName + "','" + patientDetails.PatientDateOfBirth + "','" + patientDetails.PatientEmail + "','" + patientDetails.PatientAddress + "','" + patientDetails.PatientGender + "','" + patientDetails.PatientHeight + "','" + patientDetails.PatientWeight + "','" + patientDetails.PatientBloodGroup + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdatePatient(PatientDetails patientDetails)
        {
            string sql = "Update PatientsDetails SET PatientName='" +patientDetails.PatientName+ "', PatientDateOfBirth='"+ patientDetails.PatientDateOfBirth + "',PatientEmail= '"+patientDetails.PatientEmail+ "',PatientAddress='" + patientDetails.PatientAddress + "',PatientGender='" + patientDetails.PatientGender + "',PatientWeight='" + patientDetails.PatientWeight + "',PatientHeight='" + patientDetails.PatientHeight + "',PatientBloodGroup='" + patientDetails.PatientBloodGroup + "' WHERE PatientId='" + patientDetails.PatientId+"';";
                //"INSERT INTO PatientsDetails(PatientName,PatientDateOfBirth,PatientEmail,PatientAddress,PatientGender,PatientHeight,PatientWeight,PatientBloodGroup) VALUES('" + patientDetails.PatientName + "','" + patientDetails.PatientDateOfBirth + "','" + patientDetails.PatientEmail + "','" + patientDetails.PatientAddress + "','" + patientDetails.PatientGender + "','" + patientDetails.PatientHeight + "','" + patientDetails.PatientWeight + "','" + patientDetails.PatientBloodGroup + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        //public bool UpdatePatient(int productId, string productName, double price, int quantity, int categoryId)
        // {
        //    string sql = "UPDATE Products SET ProductName='" + productName + "',Price=" + price + ",Quantity=" + quantity + ",CategoryId=" + categoryId + " WHERE ProductId=" + productId;
        //   int result = this.ExecuteQuery(sql);
        //   if (result > 0)
        //return true;
        //   else
        //     return false;
        //  }

        public bool DeletePatient(int patientID)
        {
            string sql = "DELETE FROM PatientsDetails WHERE PatientId=" + patientID;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public List<PatientDetails> GetPatientById(int patientId)
        {
            string sql = "SELECT * FROM PatientsDetails WHERE PatientId=" + patientId;
            SqlDataReader reader = this.GetData(sql);
            List<PatientDetails> patientsDetails = new List<PatientDetails>();
            while (reader.Read())
            {
                PatientDetails patientDetails = new PatientDetails();
                patientDetails.PatientId = (int)reader["PatientID"];
                patientDetails.PatientName = reader["PatientName"].ToString();
                patientDetails.PatientDateOfBirth = Convert.ToDateTime(reader["PatientDateOfBirth"]).ToString();
                patientDetails.PatientEmail = reader["PatientEmail"].ToString();
                patientDetails.PatientAddress = reader["PatientAddress"].ToString();
                patientDetails.PatientGender = reader["PatientGender"].ToString();
                patientDetails.PatientHeight = Convert.ToDouble(reader["PatientHeight"]);
                patientDetails.PatientWeight = Convert.ToDouble(reader["PatientWeight"]);
                patientDetails.PatientBloodGroup = reader["PatientBloodGroup"].ToString();

                patientsDetails.Add(patientDetails);
            }
            return patientsDetails;
        }
        int sId;
        public PatientDetails CheckPatientId(int patientId)
        {
            string sql = "SELECT * FROM PatientsDetails WHERE PatientId=" + patientId;
            SqlDataReader reader = this.GetData(sql);
            sId = patientId;
            if (reader.HasRows)
            {
                // reader.Read();
                PatientDetails patientDetails = new PatientDetails();
                //category.CategoryId = (int)reader["CategoryId"];
                // category.CategoryName = reader["CategoryName"].ToString();
                return patientDetails;
            }
            else
                return null;

        }
        public PatientDetails GetPatient(int id)
        {
            string sql = "SELECT * FROM PatientsDetails WHERE PatientId=" + id;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                PatientDetails patientDetails = new PatientDetails();
                patientDetails.PatientId = (int)reader["PatientID"];
                patientDetails.PatientName = reader["PatientName"].ToString();
                patientDetails.PatientDateOfBirth = Convert.ToDateTime(reader["PatientDateOfBirth"]).ToString();
                patientDetails.PatientEmail = reader["PatientEmail"].ToString();
                patientDetails.PatientAddress = reader["PatientAddress"].ToString();
                patientDetails.PatientGender = reader["PatientGender"].ToString();
                patientDetails.PatientHeight = Convert.ToDouble(reader["PatientHeight"]);
                patientDetails.PatientWeight = Convert.ToDouble(reader["PatientWeight"]);
                patientDetails.PatientBloodGroup = reader["PatientBloodGroup"].ToString();
                return patientDetails;
            }
            else
                return null;




        }
    }
}
