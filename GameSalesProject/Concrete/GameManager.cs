using GameSalesProject.Abstract;
using GameSalesProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " named game has been added.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " named game has been deleted.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " named game has been updated.");
        }
    }
}
