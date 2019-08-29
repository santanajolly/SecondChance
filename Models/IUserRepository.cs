using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject.Models
{
    interface IUserRepository
    {
        List<Preference> GetPreferences(int UserID);
        User Login(string Username, string Password);
        User GetByID(int UserID);
        User GetByName(string FirstName, string LastName);
    }
}
