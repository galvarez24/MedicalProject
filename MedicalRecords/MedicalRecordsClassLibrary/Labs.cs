using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordsClassLibrary
{
    class Labs
    {
        public string LabLocation { get; set; }
        public string LabDone { get; set; }
        public string LabRestuls { get; set; }
        public string LabDate { get; set; }

        public override string ToString()
        {
            return "Labs: " + LabLocation + " " + LabDone + " " + LabRestuls + " " + LabDate;
        }
    }
}
