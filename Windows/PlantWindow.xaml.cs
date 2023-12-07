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

        public ObservableCollection<Plant> Plants { get; set; }

        public PlantWindow()
        {
            InitializeComponent();
            Plants = new ObservableCollection<Plant>();
            // DatagridPlants kommer hämta data från observableCollection. 
            DatagridPlants.ItemsSource = Plants;
        }

        private void LoadPlants()
        {
            try
            {
                using (var context = new MyDBContext())
                {
                    GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);

                    // Hämta alla plants från databasen. 
                    List<Plant> plants = _unitOfWork.PlantRepository.GetAll();

                    // Töm observablelist. 
                    Plants.Clear();

                    // Lägg till varje planta till observablelist. 
                    foreach (var plant in plants)
                    {
                        if (!Plants.Any(plnt => plnt.PlantName == plant.PlantName))
                        {
                            // Lägg bara till plantan om namnet inte redan finns i listan! 
                            Plants.Add(plant);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Metod som kallas när fönstret laddas. 
            LoadPlants();
        }

        private void btnSearchPlant_Click(object sender, RoutedEventArgs e)
        {
            string searchString = txtSearchTerm.Text;

            if (string.IsNullOrEmpty(searchString))
            {
                MessageBox.Show("Please provide a full name of a plant");
                txtSearchTerm.Text = "";
                return;
            }

            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);

                Plant? identifiedPlant = _unitOfWork.PlantRepository.SearchPlant(searchString);
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
        }

        private void btnClearFilter_Click(object sender, RoutedEventArgs e)
        {
            LoadPlants();
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

        private void btnDeletePlant_Click(object sender, RoutedEventArgs e)
        {
            // Om valt item är en Plant 
            if (DatagridPlants.SelectedItem is Plant chosenPlant)
            {
                MessageBoxResult result = MessageBox.Show($"Do you want to delete {chosenPlant.PlantName}?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    int plantid = chosenPlant.PlantId;
                    using (var context = new MyDBContext())
                    {
                        GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);

                        _unitOfWork.PlantRepository.Delete(plantid);
                        _unitOfWork.Complete(); // Spara ändringarna 
                        LoadPlants();
                    }
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
