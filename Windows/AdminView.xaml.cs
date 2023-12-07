using GreenThumbProject.Data;
using System.Windows;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        public AdminView()
        {
            InitializeComponent();
        }

        // Skicka vidare admin till olika windows beroende på vald knapp. 
        private void btnPlantDatabase_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);
                PlantWindow plants = new PlantWindow();
                plants.Show();
                Close();
            }
        }

        private void btnUserDatabase_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);
                UsersWindow users = new UsersWindow();
                users.Show();
                Close();
            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void btninstructiondatabase_Click(object sender, RoutedEventArgs e)
        {
            PlantInstructionsCatalog plantInstructionsCatalog = new PlantInstructionsCatalog();
            plantInstructionsCatalog.Show();

        }
    }
}
