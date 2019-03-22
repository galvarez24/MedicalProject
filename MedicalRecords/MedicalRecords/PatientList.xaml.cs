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
using System.Windows.Shapes;

namespace MedicalRecords
{
    /// <summary>
    /// Interaction logic for PatientList.xaml
    /// </summary>
    public partial class PatientList : Window
    {
        public ObservableCollection<Patients> patientList = new ObservableCollection<MedicalRecordsClassLibrary.Patients>();



        public PatientList()
        {
            InitializeComponent();

            try
            {
                FileStream plist = new FileStream("C:\\Users\\alvar\\Documents\\MedicalProject\\MedicalRecords\\MedicalRecords\\DataBase\\patientList.txt", FileMode.Open);
                StreamReader readplist = new StreamReader(plist);

                while (readplist.Peek() != -1)
                {
                    string showplist = readplist.ReadLine();

                    string[] SplitValues = showplist.Split('|');

                    Patients p = new Patients();
                    p.PatientFirstName = SplitValues[0];
                    p.PatientLastName = SplitValues[1];
                    p.PatientDOB = SplitValues[2];
                    p.PatientAge = SplitValues[3];
                    p.PatientGender = SplitValues[4];
                    p.DateAdmitted = SplitValues[5];
                    p.PatientChiefComplaint = SplitValues[6];

                    patientList.Add(p);

                    lvPatients.ItemsSource = patientList;

                }

                plist.Close();
            }


            catch (FileNotFoundException fnf)
            {
                MessageBox.Show("File Not Found");
            }

            catch (DirectoryNotFoundException dnf)
            {
                MessageBox.Show("Directory Not Found");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error");

            }

        }
            private void Search_Click(object sender, RoutedEventArgs e)
            {

                try
                {
                    patientList.Clear();
                    FileStream plist = new FileStream("C:\\Users\\alvar\\Documents\\MedicalProject\\MedicalRecords\\MedicalRecords\\DataBase\\patientList.txt", FileMode.Open);
                    StreamReader readplist = new StreamReader(plist);
                    while (readplist.Peek() != -1)
                    {
                        string onepatient = readplist.ReadLine();
                        string[] SplitValues = onepatient.Split('|');
                        Patients patient = new Patients() { PatientFirstName = SplitValues[0], PatientLastName = SplitValues[1], PatientDOB = SplitValues[2], PatientAge = SplitValues[3], PatientGender = SplitValues[4], DateAdmitted = SplitValues[6], PatientChiefComplaint = SplitValues[7], PatientDischarged = Convert.ToBoolean(SplitValues[8]) };
                        if (SplitValues[8] == "False")
                        {
                            if ((PatientFNameSearch.Text.Length > 0) & (SplitValues[0].Contains(PatientFNameSearch.Text)) | ((PatientLNameSearch.Text.Length > 0) & (SplitValues[1].Contains(PatientLNameSearch.Text)) | ((PatientAgeSearch.Text.Length > 0) & (SplitValues[3] == (PatientAgeSearch.Text)) | ((PatientComplaintSearch.Text.Length > 0) & (SplitValues[7].Contains(PatientComplaintSearch.Text))))))
                            {
                            patientList.Add(patient);
                            }
                        }
                    }
                    plist.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Oops! Error...");
                }


            }

            private void SinglePatientInfo_Click(object sender, MouseButtonEventArgs e)
            {

            var patientinfowindow = new PatientInfo();

            patientinfowindow.Show();

            }

    }
}