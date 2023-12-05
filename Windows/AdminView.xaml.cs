using GreenThumbProject.Data;
using System.Windows;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        private readonly GreenThumbUOW _unitOfWork;
        public AdminView()
        {
            InitializeComponent();
            MyDBContext context = new MyDBContext();
            _unitOfWork = new GreenThumbUOW(context);
        }

        // Skicka vidare admin till olika windows beroende på vald knapp. 
        private void btnPlantDatabase_Click(object sender, RoutedEventArgs e)
        {
            PlantWindow plants = new PlantWindow();
            plants.Show();
            Close();
        }

        private void btnUserDatabase_Click(object sender, RoutedEventArgs e)
        {
            UsersWindow users = new UsersWindow();
            users.Show();
            Close();
        }
    }
}
