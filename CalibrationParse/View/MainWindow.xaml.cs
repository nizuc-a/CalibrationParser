using System.Windows;
using CalibrationParse.ViewModel;
using Microsoft.Win32;

namespace CalibrationParse
{
    public partial class MainWindow : Window
    {
        private OpenFileDialog openFileDialog;
        private CalibrationVM vm = new CalibrationVM();
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
            
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CLS файлы (*.CLS)| *.CLS";
            openFileDialog.RestoreDirectory = true;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            vm.OpenFile(openFileDialog);
            ComboBox.SelectedIndex = 0;
        }
    }
}