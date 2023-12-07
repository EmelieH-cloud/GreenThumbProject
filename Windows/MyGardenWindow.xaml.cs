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

        public void FillPlantData()
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new(context);
                var plants = _unitOfWork.PlantRepository.GetAll();
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

        public void FillGardenData()
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new(context);
                Garden? potentialGarden = _unitOfWork.GardenRepository.GetGardenByUserId(_user.UserId);
                if (potentialGarden != null)
                {
                    lblgardenName.Content = $"Welcome to your digital garden: {potentialGarden.Name}";
                    var plantgardens = _unitOfWork.PlantGardenRepository.GetPlantGardenbyGardenId(potentialGarden.GardenId);
                    if (plantgardens != null)
                    {
                        foreach (var plantgarden in plantgardens)
                        {
                            ListViewItem listViewItem = new ListViewItem();
                            listViewItem.Tag = plantgarden;
                            Plant? plantToDisplay = _unitOfWork.PlantRepository.GetById(plantgarden.PlantId);
                            if (plantToDisplay != null)
                            {
                                listViewItem.Content = $"PlantId: {plantToDisplay.PlantId}, {plantToDisplay.PlantName}";
                                lstplants.Items.Add(listViewItem);
                            }
                        }
                    }
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillGardenData();
            FillPlantData();
        }

        private void btnaddplant_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new(context);
                Garden? potentialGarden = _unitOfWork.GardenRepository.GetGardenByUserId(_user.UserId);
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
                            PlantGarden newPg = new PlantGarden();
                            newPg.Garden = potentialGarden;
                            newPg.Plant = newGardenPlant;
                            newPg.PlantId = newGardenPlant.PlantId;
                            newPg.GardenId = potentialGarden.GardenId;
                            _unitOfWork.PlantGardenRepository.Add(newPg);
                            _unitOfWork.Complete();
                            lstplants.Items.Clear();
                            FillGardenData();
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


        private void btnDelete_Click(object sender, RoutedEventArgs e)
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
                        _unitOfWork.PlantRepository.Delete(plantToRemove.PlantId);
                        _unitOfWork.Complete();
                        MessageBox.Show("Selected plant was removed.");
                        lstplants.Items.Clear();
                        FillGardenData();
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ListViewItem item = (ListViewItem)lstplants.SelectedItem;
            if (item != null)
            {
                PlantGarden pg = (PlantGarden)item.Tag;
                if (pg != null)
                {
                    Plant plantToView = (Plant)pg.Plant;
                    if (plantToView != null)
                    {
                        MessageBox.Show(plantToView.Details);
                    }

                }
                else
                {
                    MessageBox.Show("Please choose a plant in the list");
                }
            }
        }

        private void btnInstructiondatabase_Click(object sender, RoutedEventArgs e)
        {
            PlantInstructionsCatalog plantInstructionsCatalog = new PlantInstructionsCatalog();
            plantInstructionsCatalog.Show();
        }
    }
}

