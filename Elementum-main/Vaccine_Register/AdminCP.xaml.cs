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
    /// Interaction logic for AdminCP.xaml
    /// </summary>
    public partial class AdminCP : Window
    {
        public AdminCP()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CP.Content = new EmailSenderPage();
        }

        private void CloseBttn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
