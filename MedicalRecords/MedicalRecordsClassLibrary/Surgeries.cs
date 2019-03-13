using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordsClassLibrary
{
    class Surgeries
    {
        public string Surgery { get; set; }
        public string SurgeryDate { get; set; }

        public override string ToString()
        {
            return "Surgery Information: " + Surgery + " " + SurgeryDate;
        }
    }
}
