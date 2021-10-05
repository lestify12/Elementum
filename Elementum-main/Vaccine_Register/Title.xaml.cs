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
    /// Interaction logic for Title.xaml
    /// </summary>
    public partial class Title : Window
    {
        public Title()
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

        private void Register_Button(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow window1 = new MainWindow();
            window1.Show();
        }

        private void Admin_Button(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AdminLogin adminlogin = new AdminLogin();
            adminlogin.Show();
        }
    }
}
