using GameSalesProject.Abstract;
using GameSalesProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool IsValid(Gamer gamer)
        {
            if (gamer.FirstName == "Necdet" && gamer.LastName == "Aygün" && gamer.BirthYear == 1930 && gamer.IdentityNumber == "12345678910")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
