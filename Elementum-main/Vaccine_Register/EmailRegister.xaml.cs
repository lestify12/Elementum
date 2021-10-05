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

namespace Vaccine_Register
{
    /// <summary>
    /// Interaction logic for EmailRegister.xaml
    /// </summary>
    public partial class EmailRegister : Window
    {
        public EmailRegister()
        {
            InitializeComponent();
        }

        private void EmailTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MinimizeBttn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseBttn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void SubmitBttn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
