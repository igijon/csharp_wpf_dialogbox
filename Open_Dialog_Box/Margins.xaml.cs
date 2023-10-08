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
using System.Windows.Shapes;

namespace Open_Dialog_Box
{
    /// <summary>
    /// Lógica de interacción para Margins.xaml
    /// </summary>
    public partial class Margins : Window
    {
        public Margins()
        {
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true; //Sólo funciona si se abrió con ShowDialog();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

    }
}
