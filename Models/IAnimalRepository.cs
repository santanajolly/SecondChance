using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject.Models
{
    public interface IAnimalRepository
    {
        List<AnimalRescue> GetAllRescuesByZip(string zipcode);
        string GetNameByID(int AnimalRescueID);
        AnimalRescue GetInfoByID(int AnimalRescueID);
    }

}
