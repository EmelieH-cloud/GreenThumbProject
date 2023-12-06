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

        public async void FillGardenData()
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillGardenData();
        }
    }
}
