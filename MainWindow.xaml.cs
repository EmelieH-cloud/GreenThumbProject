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
        private readonly GreenThumbUOW _unitOfWork;
        public MainWindow()
        {
            InitializeComponent();
            MyDBContext _context = new MyDBContext();
            _unitOfWork = new GreenThumbUOW(_context);
        }

        private async void btnSignin_Click(object sender, RoutedEventArgs e)
        {
            string enteredUsername = txtUserName.Text;
            string enteredPassword = txtPassWord.Text;
            var potentialUser = await _unitOfWork.UserRepository.AuthenticateCredentialsAsync(enteredUsername, enteredPassword);

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

        }
    }
}