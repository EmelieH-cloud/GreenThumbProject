using GreenThumbProject.Data;
using GreenThumbProject.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for PlantDetailsWindow.xaml
    /// </summary>
    public partial class PlantDetailsWindow : Window

    {
        private readonly Plant _chosenPlant;
        private readonly MyDBContext _dbContext;
        private readonly GreenThumbUOW _unitOfWork;
        public ObservableCollection<Instruction> Instructions { get; set; }
        public PlantDetailsWindow(Plant plant)
        {
            InitializeComponent();
            _chosenPlant = plant;
            _dbContext = new MyDBContext();
            _unitOfWork = new GreenThumbUOW(_dbContext);
            Instructions = new ObservableCollection<Instruction>();
            dataGridInstructions.ItemsSource = Instructions;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillWithData();
        }

        private async void FillWithData()
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
            List<Instruction> plantInstructions = await _unitOfWork.InstructionRepository.GetAllPlantInstructionsAsync(plantId);
            if (plantInstructions != null)
            {
                foreach (var instruction in plantInstructions)
                {
                    Instructions.Add(instruction); // lägg till i observableCollection 
                }
            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            PlantWindow plantWindow = new PlantWindow();
            plantWindow.Show();
            Close();
        }
    }
}
