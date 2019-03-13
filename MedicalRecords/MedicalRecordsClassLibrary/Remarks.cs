using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordsClassLibrary
{
    class Remarks
    {
        public string PatientRemarks { get; set; }

        public override string ToString()
        {
            return "Special Notes" + PatientRemarks;
        }
    }
}
