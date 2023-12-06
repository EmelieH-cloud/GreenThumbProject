using GreenThumbProject.Data;
using GreenThumbProject.Models;
using System.Windows;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for AddPlantWindow.xaml
    /// </summary>
    public partial class AddPlantWindow : Window
    {
        private readonly List<Instruction> instructions = new();
        private readonly GreenThumbUOW _unitOfWork;
        private int counter = 0;
        public AddPlantWindow()
        {
            InitializeComponent();

            MyDBContext context = new MyDBContext();
            _unitOfWork = new GreenThumbUOW(context);
        }

        private void ClearAllFields()
        {
            txtPlantName.Text = "";
            txtDetailsofPlant.Text = "";
            txtInstructionforPlant.Text = "";
            counter = 0;
            lblInstructionsAdded.Content = counter.ToString();
        }

        private void FeedBackMessage()
        {
            MessageBox.Show("Plant successfully added to the database");
        }

        private async void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            string plantname = txtPlantName.Text;
            string plantdetails = txtDetailsofPlant.Text;

            if (plantname != null)
            {
                // Undersök om plantname redan finns i databasen 
                bool nameIsTaken = await _unitOfWork.PlantRepository.PlantNameIsTakenAsync(plantname);
                if (nameIsTaken)
                {
                    MessageBox.Show("A plant with this name already exists in the database, please try again.");

                    ClearAllFields();
                    return;
                }
                //==========================================================================
                else if (!nameIsTaken && plantdetails == null && instructions.Count == 0) // namnet är ledigt, inga detaljer eller instruktioner ska läggas till plantan.
                {
                    Plant plant = new Plant();
                    plant.PlantName = plantname;
                    await _unitOfWork.PlantRepository.AddAsync(plant);
                    await _unitOfWork.Complete(); // spara till databasen 
                    FeedBackMessage();
                    ClearAllFields();
                }
                else if (!nameIsTaken && plantdetails != null && instructions.Count == 0) // namnet är ledigt, detaljer ska läggas till men inga instruktioner. 
                {
                    Plant plant = new Plant();
                    plant.Details = plantdetails;
                    plant.PlantName = plantname;
                    await _unitOfWork.PlantRepository.AddAsync(plant);
                    await _unitOfWork.Complete(); // spara till databasen 
                    FeedBackMessage();
                    ClearAllFields();
                }
                else if (!nameIsTaken && plantdetails == null && instructions.Count > 0)  // namnet är ledigt, inga detaljer ska läggas till men instruktioner. 
                {
                    Plant plant = new Plant();
                    plant.PlantName = plantname;
                    await _unitOfWork.PlantRepository.AddAsync(plant);
                    await _unitOfWork.Complete(); // spara till databasen 
                    ClearAllFields();

                    // Alla instruktioner ska kopplas till denna planta. 
                    foreach (Instruction instruction in instructions)
                    {
                        plant.Instructions.Add(instruction);
                    }
                    await _unitOfWork.Complete(); // spara till databasen 
                    instructions.Clear();
                    FeedBackMessage();
                    ClearAllFields();
                    counter = 0;

                }
                else if (!nameIsTaken && plantdetails != null && instructions.Count > 0) // namnet är ledigt, både detaljer och instruktioner ska läggas till.  
                {
                    Plant plant = new Plant();
                    plant.PlantName = plantname;
                    plant.Details = plantdetails;
                    await _unitOfWork.PlantRepository.AddAsync(plant);
                    await _unitOfWork.Complete();
                    // Alla instruktioner ska kopplas till denna planta. 
                    foreach (Instruction instruction in instructions)
                    {
                        plant.Instructions.Add(instruction);
                    }
                    await _unitOfWork.Complete(); // spara till databasen
                    FeedBackMessage();
                    instructions.Clear();
                    ClearAllFields();
                    counter = 0;
                }
            }
            else if (plantname == null)
            {
                MessageBox.Show("Please provide a name for the plant");
            }

        }

        private void btnAddinstruction_Click(object sender, RoutedEventArgs e)
        {
            string instructionContent = txtInstructionforPlant.Text;
            if (instructionContent.Length > 5)
            {
                Instruction newinstruction = new();
                newinstruction.Content = instructionContent;
                instructions.Add(newinstruction);
                txtInstructionforPlant.Text = "";
                counter++;
                lblInstructionsAdded.Content = counter.ToString();
            }
            else if (instructionContent.Length <= 5)
            {
                MessageBox.Show("The instruction must contain at least 6 characters.");
            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            PlantWindow plantwindow = new PlantWindow();
            plantwindow.Show();
            Close();
        }
    }
}
