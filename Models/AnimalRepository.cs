using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassProject.Models
{
    public class AnimalRepository : IAnimalRepository
    {
        private ApplicationDbContext context;

        public AnimalRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        List<AnimalRescue> IAnimalRepository.GetAllRescuesByZip(string zipcode)
        {
            return context.AnimalRescues.Where(a => zipcode == null || a.Zipcode == zipcode).AsQueryable<AnimalRescue>().ToList();
        }

        AnimalRescue IAnimalRepository.GetInfoByID(int AnimalRescueID)
        {
            throw new NotImplementedException();
        }

        string IAnimalRepository.GetNameByID(int AnimalRescueID)
        {
            throw new NotImplementedException();
        }
    }
}
