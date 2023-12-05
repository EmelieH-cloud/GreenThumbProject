namespace GreenThumbProject.Models
{
    public class Garden
    {
        public int GardenId { get; set; } // primary key 

        public int UserId { get; set; } // Foreign key till user.

        public User User { get; set; } = null!; // navigation prop. 

        public string Name { get; set; } = null!;

        public List<PlantGarden> PlantGardens { get; set; } = new(); // many-to-many relationship with Plant

    }
}
