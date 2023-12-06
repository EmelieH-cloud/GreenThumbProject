using GreenThumbProject.Data;
using GreenThumbProject.Models;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for GardenPlantDetailsWindow.xaml
    /// </summary>
    public partial class GardenPlantDetailsWindow : Window
    {
        private readonly Plant _chosenPlant;
        private readonly MyDBContext _dbContext;
        private readonly GreenThumbUOW _unitOfWork;
        private readonly User _user;


        public GardenPlantDetailsWindow(Plant plant, User user)
        {
            InitializeComponent();
            _user = user;
            _chosenPlant = plant;
            _dbContext = new MyDBContext();
            _unitOfWork = new GreenThumbUOW(_dbContext);

        }

        private void FillWithData()
        {
            // Details

            if (_chosenPlant.Details != null)
            {
                txtPlantDetails.Text = _chosenPlant.Details;
            }

            else if (_chosenPlant.Details == null)
            {
                txtPlantDetails.Text = "Not details have been added for this plant yet.";
            }

            // Instructions
            int plantId = _chosenPlant.PlantId;
            List<Instruction> plantInstructions = _chosenPlant.Instructions;
            if (plantInstructions != null)
            {
                foreach (var instruction in plantInstructions)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = instruction;
                    item.Content = instruction.Content;
                    dataGridInstructions.Items.Add(item);
                }
            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            // Skicka med usern till gardenwindow 
            MyGardenWindow mygarden = new MyGardenWindow(_user);
            mygarden.Show();
            Close();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillWithData();
        }
    }
}
