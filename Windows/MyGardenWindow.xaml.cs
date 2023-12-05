using GreenThumbProject.Models;
using System.Windows;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for MyGardenWindow.xaml
    /// </summary>
    public partial class MyGardenWindow : Window
    {
        public MyGardenWindow(User loggedinUser)
        {
            InitializeComponent();
            lblgardenAndUser.Content = $"User: {loggedinUser.UserName}";
        }
    }
}
