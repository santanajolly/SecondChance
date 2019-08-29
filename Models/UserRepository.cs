using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject.Models
{
    public class UserRepository : IUserRepository
    {
        User IUserRepository.GetByID(int UserID)
        {
            throw new NotImplementedException();
        }

        User IUserRepository.GetByName(string FirstName, string LastName)
        {
            throw new NotImplementedException();
        }

        List<Preference> IUserRepository.GetPreferences(int UserID)
        {
            throw new NotImplementedException();
        }

        User IUserRepository.Login(string Username, string Password)
        {
            throw new NotImplementedException();
        }
    }
}
