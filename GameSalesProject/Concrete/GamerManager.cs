using GameSalesProject.Abstract;
using GameSalesProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.IsValid(gamer))
            {
                Console.WriteLine("Gamer added: " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Gamer validation failed.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted: " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated: " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
