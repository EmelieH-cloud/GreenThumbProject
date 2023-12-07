using GreenThumbProject.Data;
using GreenThumbProject.Models;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for MyGardenWindow.xaml
    /// </summary>
    public partial class MyGardenWindow : Window
    {
        private readonly User _user;

        public MyGardenWindow(User loggedinUser)
        {
            InitializeComponent();
            lblgardenAndUser.Content = $"Hello, {loggedinUser.UserName}!";
            _user = loggedinUser;
        }

        public async Task FillPlantData()
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new(context);
                var plants = await _unitOfWork.PlantRepository.GetAllAsync();
                if (plants != null)
                {
                    List<String> addedPlants = new();
                    foreach (Plant p in plants)
                    {
                        if (!addedPlants.Contains(p.PlantName))
                        {
                            addedPlants.Add(p.PlantName);
                            ComboBoxItem cbPlant = new ComboBoxItem();
                            cbPlant.Tag = p;
                            cbPlant.Content = p.PlantName;
                            cbAddPlantsToGarden.Items.Add(cbPlant);
                        }
                    }

                }
            }
        }

        public async Task FillGardenData()
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new(context);
                Garden? potentialGarden = await _unitOfWork.GardenRepository.GetGardenByUserIdAsync(_user.UserId);
                if (potentialGarden != null)
                {
                    lblgardenName.Content = $"Welcome to your digital garden: {potentialGarden.Name}";
                    var plantgardens = await _unitOfWork.PlantGardenRepository.GetPlantGardenbyGardenIdAsync(potentialGarden.GardenId);
                    if (plantgardens != null)
                    {
                        foreach (var plantgarden in plantgardens)
                        {
                            ListViewItem listViewItem = new ListViewItem();
                            listViewItem.Tag = plantgarden;
                            Plant? plantToDisplay = await _unitOfWork.PlantRepository.GetByIdAsync(plantgarden.PlantId);
                            if (plantToDisplay != null)
                            {
                                listViewItem.Content = $"{plantToDisplay.PlantName}";
                                lstplants.Items.Add(listViewItem);
                            }
                        }
                    }
                }
            }
        }

        private async Task Window_Loaded(object sender, RoutedEventArgs e)
        {
            await FillGardenData();
            await FillPlantData();
        }

        private async Task btnaddplant_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new(context);
                Garden? potentialGarden = await _unitOfWork.GardenRepository.GetGardenByUserIdAsync(_user.UserId);
                if (potentialGarden != null)
                {
                    ComboBoxItem chosenItem = (ComboBoxItem)cbAddPlantsToGarden.SelectedItem;
                    if (chosenItem != null)
                    {
                        Plant chosenPlant = (Plant)chosenItem.Tag;
                        if (chosenPlant != null)
                        {
                            Plant newGardenPlant = new Plant();
                            newGardenPlant.PlantName = chosenPlant.PlantName;
                            newGardenPlant.Details = chosenPlant.Details;
                            newGardenPlant.Instructions = new List<Instruction>(chosenPlant.Instructions);

                            PlantGarden newPg = new PlantGarden();
                            newPg.Garden = potentialGarden;
                            newPg.Plant = newGardenPlant;
                            newPg.PlantId = newGardenPlant.PlantId;
                            newPg.GardenId = potentialGarden.GardenId;

                            await _unitOfWork.PlantGardenRepository.AddAsync(newPg);
                            await _unitOfWork.Complete();

                            lstplants.Items.Clear();
                            await FillGardenData();
                        }
                    }
                }
                else if (potentialGarden == null)
                {
                    MessageBox.Show("There is no garden to add this plant to!");
                }
            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem item = (ListViewItem)lstplants.SelectedItem;
            if (item != null)
            {
                PlantGarden pg = (PlantGarden)item.Tag;
                if (pg != null)
                {
                    Plant plant = pg.Plant;
                    GardenPlantDetailsWindow gpd = new GardenPlantDetailsWindow(plant, _user);
                    gpd.Show();
                    Close();
                }
            }
            else if (item == null)
            {
                MessageBox.Show("Please select a plant in the list");
            }
        }

        private async Task btnDelete_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new(context);
                ListViewItem item = (ListViewItem)lstplants.SelectedItem;
                if (item != null)
                {
                    PlantGarden pg = (PlantGarden)item.Tag;
                    if (pg != null)
                    {
                        Plant plantToRemove = (Plant)pg.Plant;
                        await _unitOfWork.PlantRepository.DeleteAsync(plantToRemove.PlantId);
                        await _unitOfWork.Complete();
                        MessageBox.Show("Selected plant was removed.");
                        lstplants.Items.Clear();
                        await FillGardenData();
                    }
                }
            }
        }
    }
}
