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
    /// Interaction logic for PatientInfo.xaml
    /// </summary>
    public partial class PatientInfo : Window
    {
        public ObservableCollection<MedicalRecordsClassLibrary.Allergies> patientAllergies = new ObservableCollection<MedicalRecordsClassLibrary.Allergies>();
        public ObservableCollection<MedicalRecordsClassLibrary.Diagnosis> patientDiagnosis = new ObservableCollection<MedicalRecordsClassLibrary.Diagnosis>();
        public ObservableCollection<MedicalRecordsClassLibrary.Labs> patientLabs = new ObservableCollection<MedicalRecordsClassLibrary.Labs>();
        public ObservableCollection<MedicalRecordsClassLibrary.Medications> patientMedications = new ObservableCollection<MedicalRecordsClassLibrary.Medications>();
        public ObservableCollection<MedicalRecordsClassLibrary.Remarks> patientRemarks = new ObservableCollection<MedicalRecordsClassLibrary.Remarks>();
        public ObservableCollection<MedicalRecordsClassLibrary.Surgeries> patientSurgeries = new ObservableCollection<MedicalRecordsClassLibrary.Surgeries>();






        public PatientInfo()
        {
            InitializeComponent();


            try
            {
                FileStream fs = new FileStream("C:\\Users\\alvar\\Documents\\MedicalProject\\MedicalRecords\\MedicalRecords\\DataBase\\patientAllergies.txt", FileMode.Open);
                AllergiesPath.Text = fs.Name;

                StreamReader sr = new StreamReader(fs);

                while (sr.Peek() != -1)
                {
                    PatientAllergies.Text += sr.ReadToEnd();
                }

                fs.Close();
            }
            catch (FileNotFoundException fnf)
            {
                PatientAllergies.Text += "File Not Found";
            }

            catch (DirectoryNotFoundException dnf)
            {
                PatientAllergies.Text += "Directory Not Found";
            }

            catch (Exception ex)
            {
                PatientAllergies.Text += ex.Message;
            }



            try
            {
                FileStream fs = new FileStream("C:\\Users\\alvar\\Documents\\MedicalProject\\MedicalRecords\\MedicalRecords\\DataBase\\patientSurgeries.txt", FileMode.Open);
                SurgeriesPath.Text = fs.Name;

                StreamReader sr = new StreamReader(fs);

                while (sr.Peek() != -1)
                {
                    PatientSurgeries.Text += sr.ReadToEnd();
                }

                fs.Close();
            }


            catch (FileNotFoundException fnf)
            {
                PatientSurgeries.Text += "File Not Found";
            }

            catch (DirectoryNotFoundException dnf)
            {
                PatientSurgeries.Text += "Directory Not Found";
            }

            catch (Exception ex)
            {
                PatientSurgeries.Text += ex.Message;
            }



            try
            {
                FileStream fs = new FileStream("C:\\Users\\alvar\\Documents\\MedicalProject\\MedicalRecords\\MedicalRecords\\DataBase\\patientMedications.txt", FileMode.Open);
                MedicationsPath.Text = fs.Name;

                StreamReader sr = new StreamReader(fs);

                while (sr.Peek() != -1)
                {
                    PatientMedications.Text += sr.ReadToEnd();
                }

                fs.Close();
            }


            catch (FileNotFoundException fnf)
            {
                PatientMedications.Text += "File Not Found";
            }

            catch (DirectoryNotFoundException dnf)
            {
                PatientMedications.Text += "Directory Not Found";
            }

            catch (Exception ex)
            {
                PatientMedications.Text += ex.Message;
            }


            try
            {
                FileStream fs = new FileStream("C:\\Users\\alvar\\Documents\\MedicalProject\\MedicalRecords\\MedicalRecords\\DataBase\\patientLabs.txt", FileMode.Open);
                LabsPath.Text = fs.Name;

                StreamReader sr = new StreamReader(fs);

                while (sr.Peek() != -1)
                {
                    PatientLabs.Text += sr.ReadToEnd();
                }

                fs.Close();
            }


            catch (FileNotFoundException fnf)
            {
                PatientLabs.Text += "File Not Found";
            }

            catch (DirectoryNotFoundException dnf)
            {
                PatientLabs.Text += "Directory Not Found";
            }

            catch (Exception ex)
            {
                PatientLabs.Text += ex.Message;
            }



            try
            {
                FileStream fs = new FileStream("C:\\Users\\alvar\\Documents\\MedicalProject\\MedicalRecords\\MedicalRecords\\DataBase\\patientDiagnosis.txt", FileMode.Open);
                DiagnosisPath.Text = fs.Name;

                StreamReader sr = new StreamReader(fs);

                while (sr.Peek() != -1)
                {
                    PatientDiagnosis.Text += sr.ReadToEnd();
                }

                fs.Close();
            }


            catch (FileNotFoundException fnf)
            {
                PatientDiagnosis.Text += "File Not Found";
            }

            catch (DirectoryNotFoundException dnf)
            {
                PatientDiagnosis.Text += "Directory Not Found";
            }

            catch (Exception ex)
            {
                PatientDiagnosis.Text += ex.Message;
            }



            try
            {
                FileStream fs = new FileStream("C:\\Users\\alvar\\Documents\\MedicalProject\\MedicalRecords\\MedicalRecords\\DataBase\\patientRemarks.txt", FileMode.Open);
                RemarksPath.Text = fs.Name;

                StreamReader sr = new StreamReader(fs);

                while (sr.Peek() != -1)
                {
                    PatientRemakrs.Text += sr.ReadToEnd();
                }

                fs.Close();
            }


            catch (FileNotFoundException fnf)
            {
                PatientRemakrs.Text += "File Not Found";
            }

            catch (DirectoryNotFoundException dnf)
            {
                PatientRemakrs.Text += "Directory Not Found";
            }

            catch (Exception ex)
            {
                PatientRemakrs.Text += ex.Message;
            }

        }

            private void Button_Click_Save(object sender, RoutedEventArgs e)

            {
                //this way automatically closes the files and releases it once its done with it           
                using (StreamWriter outfile = new StreamWriter(AllergiesPath.Text))
                {
                    outfile.Write(PatientAllergies.Text);
                }

                //this way automatically closes the files and releases it once its done with it           
                using (StreamWriter outfile = new StreamWriter(SurgeriesPath.Text))
                {
                    outfile.Write(PatientSurgeries.Text);
                }

                //this way automatically closes the files and releases it once its done with it           
                using (StreamWriter outfile = new StreamWriter(MedicationsPath.Text))
                {
                    outfile.Write(PatientMedications.Text);
                }

                //this way automatically closes the files and releases it once its done with it           
                using (StreamWriter outfile = new StreamWriter(LabsPath.Text))
                {
                    outfile.Write(PatientLabs.Text);
                }



                if (UserPrivilege.Doctor == true)
                {
                    //this way automatically closes the files and releases it once its done with it           
                    using (StreamWriter outfile = new StreamWriter(DiagnosisPath.Text))
                    {
                        outfile.Write(PatientDiagnosis.Text);
                    }
                }

                
                

                //this way automatically closes the files and releases it once its done with it           
                using (StreamWriter outfile = new StreamWriter(RemarksPath.Text))
                {
                    outfile.Write(PatientRemakrs.Text);
                }

                
            }

    }
}

