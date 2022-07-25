using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Patient_Management_System_for_Doctors.Entities
{
    class DoctorData
    {
        public int DoctorId { get; set; }
        public String DoctorName { get; set; }
        public String DoctorUserName { get; set; }
        public String DoctorGender { get; set; }
        public String DoctorDegree { get; set; }
        public String DoctorDateOfBirth { get; set; }
        public String DoctorEmail { get; set; }
        public String DoctorPassword { get; set; }
    }
}
