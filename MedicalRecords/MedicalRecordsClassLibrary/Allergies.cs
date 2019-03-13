using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordsClassLibrary
{
    public class Allergies
    {
        public string AllergyType { get; set; }

        public override string ToString()
        {
            return "Allergy: " + AllergyType;
        }
    }
}
