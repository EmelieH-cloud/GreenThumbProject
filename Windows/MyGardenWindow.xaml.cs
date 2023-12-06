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
        private readonly GreenThumbUOW _unitOfWork;
        public MyGardenWindow(User loggedinUser)
        {
            InitializeComponent();
            MyDBContext context = new MyDBContext();
            _unitOfWork = new GreenThumbUOW(context);
            lblgardenAndUser.Content = $"Hello, {loggedinUser.UserName}!";
            _user = loggedinUser;

        }

        public async Task FillPlantData()
        {
            // Fyll comboboxen 
            var plants = await _unitOfWork.PlantRepository.GetAllAsync();
            if (plants != null)
            {
                List<String> addedPlants = new();
                foreach (Plant p in plants)
                {
                    if (!addedPlants.Contains(p.PlantName))
                    {
                        // om namnet på plantan inte blivit tillagt, lägg till den. 
                        addedPlants.Add(p.PlantName);
                        // Gör ett nytt comboboxitem för plantan
                        ComboBoxItem cbPlant = new ComboBoxItem();
                        cbPlant.Tag = p;
                        cbPlant.Content = p.PlantName;
                        // Lägg till plantan till listview. 
                        cbAddPlantsToGarden.Items.Add(cbPlant);
                    }
                }

            }
        }

        public async Task FillGardenData()
        {
            Garden? potentialGarden = await _unitOfWork.GardenRepository.GetGardenByUserIdAsync(_user.UserId);
            if (potentialGarden != null)
            {
                lblgardenName.Content = $"Welcome to your digital garden: {potentialGarden.Name}";
                // Om det finns en garden med detta userId, hämta alla plantgardens som har detta gardenId.  
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

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await FillGardenData();
            await FillPlantData();

        }

        private async void btnaddplant_Click(object sender, RoutedEventArgs e)
        {
            // Säkerställ först att det finns en garden att addera en planta till. 
            Garden? potentialGarden = await _unitOfWork.GardenRepository.GetGardenByUserIdAsync(_user.UserId);
            if (potentialGarden != null)
            {
                // Hämta valt comboboxitem 
                ComboBoxItem chosenItem = (ComboBoxItem)cbAddPlantsToGarden.SelectedItem;
                if (chosenItem != null)
                {
                    // Casta comboboxitem till en plant
                    Plant chosenPlant = (Plant)chosenItem.Tag;

                    if (chosenPlant != null)
                    {
                        // Skapa en ny instans av Plant med samma properties som vald planta. 
                        Plant newGardenPlant = new Plant();
                        newGardenPlant.PlantName = chosenPlant.PlantName;
                        newGardenPlant.Details = chosenPlant.Details;
                        newGardenPlant.Instructions = chosenPlant.Instructions;

                        // Skapa en ny instans av PlantGarden. 
                        PlantGarden newPg = new PlantGarden();
                        newPg.Garden = potentialGarden;
                        newPg.Plant = newGardenPlant;
                        newPg.PlantId = newGardenPlant.PlantId;
                        newPg.GardenId = potentialGarden.GardenId;

                        // Lägg till den nya PlantGarden i databasen.
                        await _unitOfWork.PlantGardenRepository.AddAsync(newPg);
                        await _unitOfWork.Complete();

                        //Uppdatera UI 
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

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            // Hämta listviewitem 
            ListViewItem item = (ListViewItem)lstplants.SelectedItem;
            if (item != null)
            {
                // Casta till plantgarden 
                PlantGarden pg = (PlantGarden)item.Tag;
                if (pg != null)
                {
                    // Hämta plant 
                    Plant plant = pg.Plant;
                    // Skicka med usern till detailswindow 
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

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // Hämta comboboxitem
            ListViewItem item = (ListViewItem)lstplants.SelectedItem;
            if (item != null)
            {
                // Casta till plant
                PlantGarden pg = (PlantGarden)item.Tag;
                if (pg != null)
                {
                    // Hämta plant 
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
