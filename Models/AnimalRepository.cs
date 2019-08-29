using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject.Models
{
    public class AnimalRepository : IAnimalRepository
    {
        List<AnimalRescue> IAnimalRepository.GetAllRescuesByZip(string zipcode)
        {
            throw new NotImplementedException();
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
