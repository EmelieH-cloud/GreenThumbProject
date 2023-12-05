namespace GreenThumbProject.Models
{
    public class Plant
    {
        public int PlantId { get; set; }

        public string PlantName { get; set; } = null!;

        public string? Details { get; set; }

        public List<Instruction> Instructions { get; set; } = new(); // one-to-many relationen mellan Instruktion och Planta. 

        public List<PlantGarden> PlantGardens { get; set; } = new(); // many-to-many relationship with Garden


    }


}
