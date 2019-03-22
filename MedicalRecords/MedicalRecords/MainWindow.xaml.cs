using MedicalRecordsClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedicalRecords
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        List<SystemUsers> userlist = new List<SystemUsers>();

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var ulist = new FileStream("C:\\Users\\alvar\\Documents\\MedicalProject\\MedicalRecords\\MedicalRecords\\DataBase\\usersList.txt", FileMode.Open);
                StreamReader readulist = new StreamReader(ulist);

                while (readulist.Peek() != -1)
                {
                    string showulist = readulist.ReadLine();

                    string[] SplitValues = showulist.Split('|');

                    SystemUsers u = new SystemUsers();
                    u.UserName = SplitValues[2];
                    u.UserPassword = SplitValues[3];
                    u.DoctorTitle = SplitValues[4];

                    userlist.Add(u);
                }
                ulist.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Error...");
            }

            bool logintosystem = false;

            foreach (var user in userlist)
            {
                if ((UserNameBox.Text.Trim() == user.UserName) & (PasswordBox.Password == user.UserPassword))
                {
                    PatientList newwindow = new PatientList();
                    newwindow.Show();
                    this.Close();
                    logintosystem = true;
                    SystemUsers currentuser = new SystemUsers();
                    currentuser.UserName = user.UserName;
                    if (user.DoctorTitle == "Doctor")
                    {
                       
                        UserPrivilege.Doctor = true;
                    }
                    else if (user.DoctorTitle != "Doctor")
                    {
                        UserPrivilege.Doctor = false;
                    }
                    break;
                }

            }

            if (logintosystem == false)
                MessageBox.Show("Invalid User Info...");
        }
    }

}
