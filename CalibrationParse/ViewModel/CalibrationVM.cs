using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Shapes;
using CalibrationParse.Model;
using Microsoft.Win32;
using ReactiveUI.Fody.Helpers;

namespace CalibrationParse.ViewModel
{
    public class CalibrationVM
    {
        public ObservableCollection<Calibration> Calibrations { get; } =
            new ObservableCollection<Calibration>();

        [Reactive] public Calibration SelectedParameter { get; set; } = null; 
        private string filePath;

        public CalibrationVM()
        {
        }

        public void OpenFile(OpenFileDialog openFileDialog)
        {
            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;
                Calibrations.Clear();
                FillCalibrations();
                SelectedParameter = Calibrations.First();
            }
        }

        private void FillCalibrations()
        {
            var rawParameters = DocumentOperations.FillParameterDescription(filePath, out int weight);
            var position = DocumentOperations.FindPosition(filePath);
            foreach (var data in DocumentOperations.ReadBinaryFile(filePath, position, weight))
            {
                var calibration = DocumentOperations.FillParameterValue(rawParameters, data);
                Calibrations.Add(new Calibration(calibration));
            }
        }
    }
}