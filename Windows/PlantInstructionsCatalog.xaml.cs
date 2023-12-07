using GreenThumbProject.Data;
using GreenThumbProject.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for PlantInstructionsCatalog.xaml
    /// </summary>
    public partial class PlantInstructionsCatalog : Window
    {
        public ObservableCollection<Instruction> Instructions { get; set; }

        public PlantInstructionsCatalog()
        {
            InitializeComponent();
            Instructions = new ObservableCollection<Instruction>();
            lstinstructions.ItemsSource = Instructions;

        }

        public void FillwithInstructions()
        {
            using (var context = new MyDBContext())
            {

                GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);
                var instructionRegistry = _unitOfWork.InstructionRepository.GetAll();
                List<int> plantsId = new List<int>();
                foreach (var instruction in instructionRegistry)
                {
                    int id = instruction.PlantId;
                    if (!plantsId.Contains(id))
                    {
                        Instructions.Add(instruction);
                    }
                    plantsId.Add(id);
                }

            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillwithInstructions();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
