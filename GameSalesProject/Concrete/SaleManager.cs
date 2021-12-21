using GameSalesProject.Abstract;
using GameSalesProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Campaign campaign, Game game)
        {
            Console.WriteLine("***SALE DETAILS***\nGamer: " + gamer.FirstName + " " + gamer.LastName + " Name of game: " + game.Name + " by " + campaign.Name);
        }
    }
}
