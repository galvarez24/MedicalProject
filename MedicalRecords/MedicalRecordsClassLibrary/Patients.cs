using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordsClassLibrary
{
    class Patients
    {
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime PatientDOB { get; set; }
        public string PatientAge { get; set; }
        public string PatientGender { get; set; }
        public DateTime DateAdmitted { get; set; }
        public string PatientID { get; set; }
        public string PatientChiefComplaint { get; set; }
        public string HbA1cResult { get; set; }
        public bool PatientDischarged { get; set; }


        static public Patients NewPatient(string FName, string LName, DateTimeKind DOB, string Age, string Gender, DateTime Date, string ChiefComplaint, string HbA1c)
        {
            return new Patients() { PatientFirstName = FName, PatientLastName = LName, PatientDOB = DOB, PatientAge = Age, PatientGender = Gender, DateAdmitted = Date, PatientID = new Random().Next(0, 2500).ToString(), PatientChiefComplaint = ChiefComplaint, HbA1cResult = HbA1c };
        }

        public override string ToString()
        {
            return "Patient Information" + PatientFirstName + " " + PatientLastName + " " + PatientDOB + " " + PatientAge + " " + PatientGender + " " + DateAdmitted + " " + PatientID + " " + PatientChiefComplaint + " " + HbA1cResult + " " + PatientDischarged;
        }



    }
}
