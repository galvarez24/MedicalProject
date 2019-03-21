using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordsClassLibrary
{
    public class SystemUsers
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool DoctorPrivilege { get; set; }


        static public SystemUsers CreateNewUser(string FName, string LName, string UName, string Password, bool Privilege)
        {
            return new SystemUsers() { UserFirstName = FName, UserLastName = LName, UserName = UName, UserPassword = Password, DoctorPrivilege = Privilege };
        }

        public override string ToString()
        {
            return "User: " + UserFirstName + " " + UserLastName + " " + UserName + " " + UserPassword + " " + DoctorPrivilege;
        }

    }
}
