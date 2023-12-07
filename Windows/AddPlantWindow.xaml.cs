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
        private int counter = 0;

        public AddPlantWindow()
        {
            InitializeComponent();
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

        private async Task FinishButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDBContext())
            {
                GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);

                string plantname = txtPlantName.Text;
                string plantdetails = txtDetailsofPlant.Text;

                if (plantname != null)
                {
                    bool nameIsTaken = await _unitOfWork.PlantRepository.PlantNameIsTakenAsync(plantname);
                    if (nameIsTaken)
                    {
                        MessageBox.Show("A plant with this name already exists in the database, please try again.");

                        ClearAllFields();
                        return;
                    }

                    else if (!nameIsTaken && plantdetails == null && instructions.Count == 0)
                    {
                        Plant plant = new Plant();
                        plant.PlantName = plantname;
                        await _unitOfWork.PlantRepository.AddAsync(plant);
                        await _unitOfWork.Complete();
                        FeedBackMessage();
                        ClearAllFields();
                    }
                    else if (!nameIsTaken && plantdetails != null && instructions.Count == 0)
                    {
                        Plant plant = new Plant();
                        plant.Details = plantdetails;
                        plant.PlantName = plantname;
                        await _unitOfWork.PlantRepository.AddAsync(plant);
                        await _unitOfWork.Complete();
                        FeedBackMessage();
                        ClearAllFields();
                    }
                    else if (!nameIsTaken && plantdetails == null && instructions.Count > 0)
                    {
                        Plant plant = new Plant();
                        plant.PlantName = plantname;
                        await _unitOfWork.PlantRepository.AddAsync(plant);
                        ClearAllFields();

                        foreach (Instruction instruction in instructions)
                        {
                            plant.Instructions.Add(instruction);
                        }
                        await _unitOfWork.Complete();
                        instructions.Clear();
                        FeedBackMessage();
                        ClearAllFields();
                        counter = 0;
                    }
                    else if (!nameIsTaken && plantdetails != null && instructions.Count > 0)
                    {
                        Plant plant = new Plant();
                        plant.PlantName = plantname;
                        plant.Details = plantdetails;
                        await _unitOfWork.PlantRepository.AddAsync(plant);

                        foreach (Instruction instruction in instructions)
                        {
                            plant.Instructions.Add(instruction);
                        }
                        await _unitOfWork.Complete();
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
        }

        private void btnAddinstruction_Click(object sender, RoutedEventArgs e)
        {
            string instructionContent = txtInstructionforPlant.Text;
            if (instructionContent.Length > 5)
            {
                Instruction newinstruction = new Instruction();
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
