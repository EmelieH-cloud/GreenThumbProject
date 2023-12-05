using GreenThumbProject.Data;
using GreenThumbProject.Models;
using System.Windows;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for MyGardenWindow.xaml
    /// </summary>
    public partial class MyGardenWindow : Window
    {
        private readonly User _user;
        private readonly GreenThumbUOW _unitOfWork;
        public MyGardenWindow(User loggedinUser)
        {
            InitializeComponent();
            MyDBContext context = new MyDBContext();
            _unitOfWork = new GreenThumbUOW(context);
            lblgardenAndUser.Content = $"Hello, {loggedinUser.UserName}!";
            _user = loggedinUser;
        }

        public async void FillGardenData()
        {
            Garden? potentialGarden = await _unitOfWork.GardenRepository.GetGardenByUserIdAsync(_user.UserId);
            if (potentialGarden != null)
            { // om usern har en trädgård så ska alla växter i den displayas i datagrid. 

            }
        }
    }
}
