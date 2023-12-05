using GreenThumbProject.Data;
using GreenThumbProject.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for PlantWindow.xaml
    /// </summary>
    public partial class PlantWindow : Window
    {
        private readonly MyDBContext _dbContext;
        private readonly GreenThumbUOW _unitOfWork;
        public ObservableCollection<Plant> Plants { get; set; }

        public PlantWindow()
        {
            InitializeComponent();
            _dbContext = new MyDBContext();
            _unitOfWork = new GreenThumbUOW(_dbContext);
            Plants = new ObservableCollection<Plant>();
            // DatagridPlants kommer hämta data från observableCollection. 
            DatagridPlants.ItemsSource = Plants;

        }

        private async Task LoadPlantsAsync()
        {
            try
            {
                // Hämta alla plants från databasen. 
                List<Plant> plants = await _unitOfWork.PlantRepository.GetAllAsync();

                // Töm observablelist. 
                Plants.Clear();

                // Lägg till varje planta till observablelist. 
                foreach (var plant in plants)
                {
                    Plants.Add(plant);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        { // Metod som kallas när fönstret laddas. 

            await LoadPlantsAsync();

        }

        private async void btnSearchPlant_Click(object sender, RoutedEventArgs e)
        {
            string searchString = txtSearchTerm.Text;

            if (string.IsNullOrEmpty(searchString))
            {
                MessageBox.Show("Please provide a full name of a plant");
                txtSearchTerm.Text = "";
                return;
            }

            Plant? identifiedPlant = await _unitOfWork.PlantRepository.SearchPlantAsync(searchString);
            if (identifiedPlant != null)
            {
                Plants.Clear(); // datagrid hämtar data från observableCollection: Plants 
                Plants.Add(identifiedPlant);
            }
        }

        private async void btnClearFilter_Click(object sender, RoutedEventArgs e)
        {
            await LoadPlantsAsync();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            AdminView admin = new AdminView();
            admin.Show();
            Close();
        }

        private void btnDetailsPlant_Click(object sender, RoutedEventArgs e)
        {
            // Om valt item är en Plant 
            if (DatagridPlants.SelectedItem is Plant chosenPlant)
            {
                // Öppna PlantDetailsWindow
                PlantDetailsWindow plantDetailsWindow = new PlantDetailsWindow(chosenPlant);
                plantDetailsWindow.Show();
                Close();
            }
        }
    }
}
