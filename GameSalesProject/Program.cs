using GameSalesProject.Concrete;
using GameSalesProject.Entity;
using System;

namespace GameSalesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                FirstName = "Necdet",
                LastName = "Aygün",
                BirthYear = 1930,
                IdentityNumber = "12345678910"
            };

            Gamer gamer2 = new Gamer()
            {
                FirstName = "Yasemin",
                LastName = "Ünsal",
                BirthYear = 1932,
                IdentityNumber = "10987654321"
            };

            Campaign campaign = new Campaign()
            {
                Id = 1,
                Name = "BigGame",
                Discount = 40
            };

            Game game = new Game()
            {
                Id = 1,
                Name = "Sims",
                Price = 139,
                UnitStock = 12
            };


            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Update(gamer1);

            gamerManager.Add(gamer2);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer2);

            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Delete(game);
            gameManager.Update(game);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer1, campaign, game);
            saleManager.Sale(gamer2, campaign, game);

            Console.Read();
        }
    }
}
