using GreenThumbProject.Data;
using GreenThumbProject.Models;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbProject.Windows
{
    /// <summary>
    /// Interaction logic for PlantInstructionsCatalog.xaml
    /// </summary>
    public partial class PlantInstructionsCatalog : Window
    {



        public PlantInstructionsCatalog()
        {
            InitializeComponent();


        }

        public void FillwithInstructions()
        {
            using (var context = new MyDBContext())
            {

                GreenThumbUOW _unitOfWork = new GreenThumbUOW(context);
                var instructionRegistry = _unitOfWork.InstructionRepository.GetAll();
                string listcontent = "";
                List<string> addedStrings = new();

                foreach (var instruction in instructionRegistry)
                {
                    int id = instruction.PlantId;
                    Plant? p = _unitOfWork.PlantRepository.GetById(id);

                    if (p != null)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listcontent = $"{p.PlantName},   {instruction.Content}";
                        listViewItem.Content = listcontent;
                        // Gå bara vidare om denna sträng inte redan finns. 
                        if (!addedStrings.Contains(listcontent))
                        {
                            addedStrings.Add(listcontent);
                            lstinstructions.Items.Add(listViewItem);
                        }

                    }
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
