using System.Collections.Generic;

namespace ClassProject.Models
{
    public interface IAnimalRepository
    {
        List<AnimalRescue> GetAllRescuesByZip(string zipcode);
        string GetNameByID(int AnimalRescueID);
        AnimalRescue GetInfoByID(int AnimalRescueID);
    }

}
