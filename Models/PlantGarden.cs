namespace GreenThumbProject.Models
{
    public class PlantGarden
    {
        // Primary key är en 'composite key' och definieras i dbContext-klassen. 
        public int PlantId { get; set; }
        public Plant Plant { get; set; } = null!;

        public int GardenId { get; set; }
        public Garden Garden { get; set; } = null!;


    }
}
