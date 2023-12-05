namespace GreenThumbProject.Models
{
    public class Instruction
    {
        public int InstructionId { get; set; }

        public int PlantId { get; set; }

        public string Content { get; set; } = null!;

        public Plant Plant { get; set; } = null!;
    }
}
