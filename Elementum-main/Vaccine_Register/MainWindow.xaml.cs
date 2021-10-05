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
using System.Text.RegularExpressions;

namespace Vaccine_Register
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

        private void Titlebar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void MinimizeBttn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseBttn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void NumValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9-]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void DateValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9/]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SubmitBttn_Click(object sender, RoutedEventArgs e)
        {            
            // Strings
            String FullName = NameTxtbox.Text;
            String Address = AddressTxtbox.Text;
            String ContactNumber = ContactTxtbox.Text;
            String PhilhealthNumber = PhilhealthTxtbox.Text;
            String Category = CategoryTxtbox.Text;            

            // Check if theres value in the Birthday
            DateTime? selectedDate = BirthdayDatePicker.SelectedDate;
            if (selectedDate.HasValue)
            {
                String Birthdate = selectedDate.Value.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);                
            }
        }

        private void CancelBttn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Title window2 = new Title();
            window2.Show();
        }
    }
}