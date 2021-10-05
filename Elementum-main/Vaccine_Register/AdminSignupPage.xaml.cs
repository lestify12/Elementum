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
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Vaccine_Register
{
    /// <summary>
    /// Interaction logic for Signup_Page.xaml
    /// </summary>
    public partial class AdminSignupPage : Page
    {
        public AdminSignupPage()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig() {
            AuthSecret = "56PLmaTm31paeX9Yj2T0HMKgcN1Hw3xLjYe1Kupy",
            BasePath = "https://vaccination-card-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            try {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch {
                MessageBox.Show("No Connection Problem");
            }
        }
        private void Signupbtn(object sender, RoutedEventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(SUusertxtbox.Text) &&
                string.IsNullOrWhiteSpace(SUpasswordtxtbox.Text)) {
                MessageBox.Show("Please Input Correct Details");
                return;
            }


            #endregion

            MyUser user = new MyUser() {
                Username = SUusertxtbox.Text,
                Password = SUpasswordtxtbox.Text,

            };
            SetResponse set = client.Set("@Users/" + SUusertxtbox.Text, user);
            MessageBox.Show("Successfully Registered!");
        }

        private void SUpasswordtxtbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

   