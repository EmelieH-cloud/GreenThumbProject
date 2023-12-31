﻿using GreenThumbProject.Models;

namespace GreenThumbProject.Data
{
    public class GreenThumbUOW
    {
        public GardenRepository<Garden> GardenRepository { get; }
        public PlantRepository<Plant> PlantRepository { get; }
        public UserRepository<User> UserRepository { get; }
        public PlantGardenRepository<PlantGarden> PlantGardenRepository { get; }
        public InstructionRepository<Instruction> InstructionRepository { get; }

        private readonly MyDBContext _DBcontext;

        public GreenThumbUOW(MyDBContext context)
        {
            _DBcontext = context;
            UserRepository = new(context);
            PlantRepository = new(context);
            InstructionRepository = new(context);
            GardenRepository = new(context);
            PlantGardenRepository = new(context);
        }

        public void Complete()
        {
            _DBcontext.SaveChanges();
        }
    }
}