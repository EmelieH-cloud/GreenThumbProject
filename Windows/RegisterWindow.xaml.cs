using GreenThumbProject.Data;
using GreenThumbProject.Models;
using GreenThumbProject.Utility;
using System.Windows;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private readonly CredentialsValidator _validator;
        private readonly GreenThumbUOW _unitOfWork;
        public RegisterWindow()
        {
            InitializeComponent();
            MyDBContext context = new MyDBContext();
            _unitOfWork = new GreenThumbUOW(context);
            _validator = new CredentialsValidator();
        }

        private async void btnregister_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool usernameIsMinimumFiveChars = _validator.LengthRequirementAchieved(username);
            bool passwordIsMinimumFiveChars = _validator.LengthRequirementAchieved(password);
            bool usernameContainsAtLeastOneNbr = _validator.ContainsAtLeastOneNumber(username);
            bool passwordContainsAtLeastOneNbr = _validator.ContainsAtLeastOneNumber(password);

            if (usernameIsMinimumFiveChars && passwordIsMinimumFiveChars && usernameContainsAtLeastOneNbr && passwordContainsAtLeastOneNbr)
            {
                bool nameIsAvailable = await _unitOfWork.UserRepository.UserNameIsAvailableAsync(username);
                if (nameIsAvailable)
                {
                    User newUser = new User();
                    newUser.UserName = username;
                    newUser.Password = password;
                    await _unitOfWork.UserRepository.AddAsync(newUser);
                    await _unitOfWork.Complete();
                    MessageBox.Show("User was succesfully registered.");
                    txtPassword.Text = "";
                    txtUsername.Text = "";

                }
                else if (!nameIsAvailable)
                {
                    MessageBox.Show("That username already exists, please try again.");
                }

            }
            else
            {
                MessageBox.Show("Username and password must be at least 5 characters long and contain at least 1 number.");
                txtPassword.Text = "";
                txtUsername.Text = "";
            }

        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
