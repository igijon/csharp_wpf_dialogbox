using System;
using System.Collections.Generic;
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

namespace Common_Dialog_Box
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

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text documents (.txt)|*.txt";

            bool? result = dialog.ShowDialog();

            if(result == true)
            {
                MessageBox.Show($"Aquí abriríamos el archivo {dialog.FileName}");
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32. SaveFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text documents (.txt)|*.txt";

            bool? result = dialog.ShowDialog();
            if(result == true)
            {
                MessageBox.Show($"Aquí guardaríamos el archivo {dialog.FileName}");
            }
        }

        private void btnConfigurePrinter_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Controls.PrintDialog();
            dialog.PageRangeSelection = System.Windows.Controls.PageRangeSelection.AllPages;
            dialog.UserPageRangeEnabled = true;

            bool? result = dialog.ShowDialog();

            if(result == true)
            {
                MessageBox.Show("El documento fue impreso.");
            }
            else
            {
                MessageBox.Show("No se imprimió el documento.");
            }
        }
    }
}
