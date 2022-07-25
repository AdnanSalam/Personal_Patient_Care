using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Patient_Management_System_for_Doctors.Entities
{
    class PatientDetails
    {
        public int PatientId { get; set; }
        public String PatientName { get; set; }
        public String PatientDateOfBirth { get; set; }
        public String PatientEmail { get; set; }
        public String PatientAddress { get; set; }
        public String PatientGender { get; set; }
        public double PatientHeight { get; set; }
        public double PatientWeight { get; set; }
        public String PatientBloodGroup { get; set; }
        //public int PId { get; set; }

    }
}