using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordsClassLibrary
{
    public class Diagnosis
    {
        public string Doctor { get; set; }
        public string DoctorDiagnosis { get; set; }
        public DateTime DiagnosisDate { get; set; }
        public string Treatment { get; set; }
        public string TreatmentDuration { get; set; }

        public override string ToString()
        {
            return "Diagnosis: " + Doctor + " " + DoctorDiagnosis + " " + DiagnosisDate + " " + Treatment + " " + TreatmentDuration;
        }

    }
}
