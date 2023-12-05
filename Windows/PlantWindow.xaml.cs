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

            else if (identifiedPlant == null)
            {
                MessageBox.Show("Plant not found");
                txtSearchTerm.Text = "";
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
            else
            {
                MessageBox.Show("Please select a plant in the list");
            }
        }

        private async void btnDeletePlant_Click(object sender, RoutedEventArgs e)
        {
            // Om valt item är en Plant 
            if (DatagridPlants.SelectedItem is Plant chosenPlant)
            {
                MessageBoxResult result = MessageBox.Show($"Do you want to delete {chosenPlant.PlantName}?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    int plantid = chosenPlant.PlantId;
                    await _unitOfWork.PlantRepository.DeleteAsync(plantid);
                    await _unitOfWork.Complete(); // Spara ändringarna 
                    await LoadPlantsAsync();
                }

            }
            else
            {
                MessageBox.Show("Please select a plant in the list");
            }
        }

        private void btnAddPlantsWindow_Click(object sender, RoutedEventArgs e)
        {
            AddPlantWindow addplantwindow = new AddPlantWindow();
            addplantwindow.Show();
            Close();
        }
    }
}
