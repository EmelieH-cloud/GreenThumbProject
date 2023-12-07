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

        public UsersWindow()
        {
            InitializeComponent();

        }

        public void LoadUserData()
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);

                var users = _unitOfWork.UserRepository.GetAll();
                foreach (var user in users)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = user;
                    item.Content = user.UserName;
                    lstUsers.Items.Add(item);
                }
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
