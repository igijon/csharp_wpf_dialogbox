﻿using System;
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

namespace Open_Dialog_Box
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var marginsWindow = new Margins();

            marginsWindow.Closed += (sender, eventArgs) =>
            {
                MessageBox.Show($"You closed the margins window! It had the title of {marginsWindow.Title}");
            };

            bool? result = marginsWindow.ShowDialog();
            
            if ( result == true )
            {
                MessageBox.Show("Your request will be processed.");
            }
            else
            {
                MessageBox.Show("Sorry it didn't work out, we'll try again later.");
            }
        }
    }
}
