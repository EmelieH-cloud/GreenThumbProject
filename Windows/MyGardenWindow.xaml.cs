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
                foreach (Plant p in plants)
                {
                    ComboBoxItem cbItem = new ComboBoxItem();
                    cbItem.Tag = p;
                    cbItem.Content = p.PlantName;
                    cbAddPlantsToGarden.Items.Add(cbItem);
                }

            }
        }

        public async Task FillGardenData()
        {
            Garden? potentialGarden = await _unitOfWork.GardenRepository.GetGardenByUserIdAsync(_user.UserId);
            if (potentialGarden != null)
            { // Om det finns en garden med detta userId, hämta alla plantgardens som har detta gardenId.  
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

                        // Lägg till den nya plantan i databasen.
                        await _unitOfWork.PlantRepository.AddAsync(newGardenPlant);
                        await _unitOfWork.Complete();

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

    }
}
