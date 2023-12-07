using GreenThumbProject.Data;
using GreenThumbProject.Windows;
using System.Windows;

namespace GreenThumbProject
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

        private void btnSignin_Click(object sender, RoutedEventArgs e)
        {
            string enteredUsername = txtUserName.Text;
            string enteredPassword = txtPassWord.Text;

            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);
                var potentialUser = _unitOfWork.UserRepository.AuthenticateCredentials(enteredUsername, enteredPassword);

                // Om användaren vill logga in som admin, öppna adminfönstret. 
                if (potentialUser != null && potentialUser.UserName == "AdminUser" && potentialUser.Password == "AdminPassword")
                {
                    AdminView admin = new AdminView();
                    admin.Show();
                    Close();
                }

                // Om användaren vill logga in som vanlig user, öppna MyGardenWindow.
                else if (potentialUser != null && potentialUser.UserName != "AdminUser" && potentialUser.Password != "AdminPassword")
                {
                    MyGardenWindow mygarden = new MyGardenWindow(potentialUser);
                    mygarden.Show();
                    Close();
                }

                else
                {
                    MessageBox.Show("No user found");
                }
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Close();
        }
    }
}