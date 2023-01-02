using Authorization.DTO;
using Authorization.Services;
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

namespace Authorization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UsersService _usersservice;
        public MainWindow()
        {
            InitializeComponent();
            _usersservice = new UsersService();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(LoginBox.Text) && !string.IsNullOrEmpty(PasswordBox.Text))
            {
                if (_usersservice.Check(new UserDTO() {Email = LoginBox.Text, Password = PasswordBox.Text }))
                {
                    new chat_application.MainWindow().Show();
                    this.Close();
                }
            }
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            
            if (!string.IsNullOrEmpty(LoginBox.Text) && !string.IsNullOrEmpty(PasswordBox.Text))
            {
                if (!_usersservice.CheckEmail(LoginBox.Text))
                {
                    _usersservice.Add(new UserDTO() { Email = LoginBox.Text, Password = PasswordBox.Text });
                    MessageBox.Show($"Added new user with email {LoginBox.Text}");
                }
                else
                {
                    MessageBox.Show("User with this email already exists!");
                }
            }
        }
    }
}
