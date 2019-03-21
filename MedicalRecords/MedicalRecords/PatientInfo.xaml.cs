using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        }
    }
}
