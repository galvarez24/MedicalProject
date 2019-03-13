using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordsClassLibrary
{
    class Medications
    {
        public string MedicationType { get; set; }
        public string DatePrescribed { get; set; }
        public string MedicationDosage { get; set; }
        public string MedicationDuration { get; set; }

        public override string ToString()
        {
            return "Medication Information: " + MedicationType + " " + DatePrescribed + " " + MedicationDosage + " " + MedicationDuration;
        }

    }
}
