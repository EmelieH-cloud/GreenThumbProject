namespace GreenThumbProject.Models
{
    public class Instruction
    {
        public int InstructionId { get; set; }

        public int PlantId { get; set; }

        public Plant Plant { get; set; } = null!;
    }
}
