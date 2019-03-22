using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordsClassLibrary
{
    public class Patients
    {
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientDOB { get; set; }
        public string PatientAge { get; set; }
        public string PatientGender { get; set; }
        public string DateAdmitted { get; set; }
        public string PatientChiefComplaint { get; set; }
        public string HbA1cResult { get; set; }
        public bool PatientDischarged { get; set; }


        static public Patients NewPatient(string FName, string LName, string DOB, string Age, string Gender, string Date, string ChiefComplaint, string HbA1c)
        {
            return new Patients() { PatientFirstName = FName, PatientLastName = LName, PatientDOB = DOB, PatientAge = Age, PatientGender = Gender, DateAdmitted = Date, PatientChiefComplaint = ChiefComplaint, HbA1cResult = HbA1c };
        }

        public override string ToString()
        {
            return "Patient Information" + PatientFirstName + " " + PatientLastName + " " + PatientDOB + " " + PatientAge + " " + PatientGender + " " + DateAdmitted + " " + " " + PatientChiefComplaint + " " + HbA1cResult + " " + PatientDischarged;
        }



    }
}
