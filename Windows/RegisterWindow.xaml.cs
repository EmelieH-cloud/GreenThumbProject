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

        public RegisterWindow()
        {
            InitializeComponent();
            _validator = new CredentialsValidator();
        }

        private void btnregister_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);

                string username = txtUsername.Text;
                string password = txtPassword.Text;
                bool usernameIsMinimumFiveChars = _validator.LengthRequirementAchieved(username);
                bool passwordIsMinimumFiveChars = _validator.LengthRequirementAchieved(password);
                bool usernameContainsAtLeastOneNbr = _validator.ContainsAtLeastOneNumber(username);
                bool passwordContainsAtLeastOneNbr = _validator.ContainsAtLeastOneNumber(password);

                if (usernameIsMinimumFiveChars && passwordIsMinimumFiveChars && usernameContainsAtLeastOneNbr && passwordContainsAtLeastOneNbr)
                {
                    bool nameIsAvailable = _unitOfWork.UserRepository.UserNameIsAvailable(username);
                    if (nameIsAvailable)
                    {
                        User newUser = new User();
                        newUser.UserName = username;
                        newUser.Password = password;
                        _unitOfWork.UserRepository.Add(newUser);
                        _unitOfWork.Complete();

                        Garden newGarden = new Garden();
                        newGarden.Name = username + "'s" + " garden";
                        newGarden.UserId = newUser.UserId;
                        _unitOfWork.GardenRepository.Add(newGarden);
                        _unitOfWork.Complete();

                        MessageBox.Show("New user: " + newUser.UserName + " registered with new garden: " + newGarden.Name);
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
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
