using GreenThumbProject.Data;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        private readonly MyDBContext _dbContext;
        private readonly GreenThumbUOW _unitOfWork;
        public UsersWindow()
        {
            InitializeComponent();
            _dbContext = new MyDBContext();
            _unitOfWork = new GreenThumbUOW(_dbContext);

        }

        public async void LoadUserData()
        {
            var users = await _unitOfWork.UserRepository.GetAllAsync();
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = user;
                item.Content = user.UserName;
                lstUsers.Items.Add(item);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminView adminView = new AdminView();
            adminView.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadUserData();
        }
    }
}
