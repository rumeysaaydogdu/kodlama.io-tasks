using GameSalesProject.Abstract;
using GameSalesProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added: " + campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted: " + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated: " + campaign.Name);
        }
    }
}
