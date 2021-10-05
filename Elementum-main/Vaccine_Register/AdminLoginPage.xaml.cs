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
    /// Interaction logic for AdminLoginPage.xaml
    /// </summary>
    public partial class AdminLoginPage : Page
    {
        public AdminLoginPage()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig() {
            AuthSecret = "56PLmaTm31paeX9Yj2T0HMKgcN1Hw3xLjYe1Kupy",
            BasePath = "https://vaccination-card-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            try {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch {
                MessageBox.Show("No Connection Problem");
            }
        }
        private void Loginbtn(object sender, RoutedEventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(UsernameTxtBox.Text) &&
                string.IsNullOrWhiteSpace(PasswordTxtBox.Text)) {
                MessageBox.Show("Please Input Correct Details ");

                return;
            }


            #endregion
            FirebaseResponse res = client.Get("@Users/" + UsernameTxtBox.Text);
            MyUser ResUser = res.ResultAs<MyUser>(); //para sa database nga results
            MyUser CurUser = new MyUser() // USER GIVEN INFO
            {
                Username = UsernameTxtBox.Text,
                Password = PasswordTxtBox.Text
            };
            if (MyUser.IsEqual(ResUser, CurUser)) {

                AdminCP window1 = new AdminCP();
                window1.Show();

            }

            else {
                MyUser.ShowError();
            }
          

        }

        private void UsernameTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
