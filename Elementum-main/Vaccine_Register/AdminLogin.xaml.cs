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
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public AdminLogin()
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
            this.Hide();
            Title title = new Title();
            title.Show();
        }

        private void LoginPageBtn(object sender, RoutedEventArgs e)
        {
            Admin.Content = new AdminLoginPage();
        }

        private void RegPageBtn(object sender, RoutedEventArgs e)
        {
            Admin.Content = new AdminSignupPage();
        }

        private void Loginbtn(object sender, RoutedEventArgs e)
        {

        }
    }
}
