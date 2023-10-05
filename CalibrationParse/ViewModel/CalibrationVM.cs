using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows.Shapes;
using CalibrationParse.Model;
using Microsoft.Win32;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace CalibrationParse.ViewModel
{
    public class CalibrationVM
    {
        public ObservableCollection<Calibration> Calibrations { get; } =
            new ObservableCollection<Calibration>();
        
        [Reactive] public Calibration SelectedParameter { get; set; }

        [Reactive] public string FilePath
        {
            get;
            private set;
        }

        public CalibrationVM()
        {
            
        }
        
        

        public void OpenFile(OpenFileDialog openFileDialog)
        {
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                Calibrations.Clear();
                FillCalibrations();
                SelectedParameter = Calibrations.First();
            }
        }

        private void FillCalibrations()
        {
            var rawParameters = DocumentOperations.FillParameterDescription(FilePath, out int weight);
            var position = DocumentOperations.FindPosition(FilePath);
            foreach (var data in DocumentOperations.ReadBinaryFile(FilePath, position, weight))
            {
                var calibration = DocumentOperations.FillParameterValue(rawParameters, data);
                Calibrations.Add(new Calibration(calibration));
            }
        }
    }
}