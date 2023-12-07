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
        private readonly MyDBContext _context;
        public ObservableCollection<Instruction> Instructions { get; set; }
        private readonly GreenThumbUOW _unitOfWork;

        public PlantDetailsWindow(Plant plant)
        {
            InitializeComponent();
            _chosenPlant = plant;
            _context = new MyDBContext();
            _unitOfWork = new GreenThumbUOW(_context);
            Instructions = new ObservableCollection<Instruction>();
            dataGridInstructions.ItemsSource = Instructions;
            lblplantName.Content = "Plant details: " + plant.PlantName;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillWithData();
        }

        private void FillWithData()
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);

                // Details
                if (_chosenPlant.Details != null)
                {
                    txtPlantDetails.Text = _chosenPlant.Details;
                }
                else
                {
                    txtPlantDetails.Text = "No details have been added for this plant yet.";
                }

                // Instructions
                int plantId = _chosenPlant.PlantId;
                List<Instruction> plantInstructions = _unitOfWork.InstructionRepository.GetAllPlantInstructions(plantId);
                if (plantInstructions != null)
                {
                    foreach (var instruction in plantInstructions)
                    {
                        Instructions.Add(instruction); // lägg till i observableCollection 
                    }
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
