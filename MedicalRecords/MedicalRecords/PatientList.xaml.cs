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
    /// Interaction logic for PatientList.xaml
    /// </summary>
    public partial class PatientList : Window
    {
        public ObservableCollection<MedicalRecordsClassLibrary.Patients> patientList = new ObservableCollection<MedicalRecordsClassLibrary.Patients>();

        public PatientList()
        {
            InitializeComponent();
        }
    }
}
