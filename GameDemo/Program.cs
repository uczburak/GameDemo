using GameDemo.Entity;
using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Adapter;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer = new Gamer
            {
                Id = 1,
                FirstName = "burak",
                LastName = "ucuz",
                City = "Mardin",
                NationalityId = "54632157541",
                DateOfBirth = new DateTime(1992, 04, 23),
                UserName = "Frozen"
            };

            gamerManager.Add(gamer);

            Game game = new Game
            {
                GameName = "PUBG",
                Id = 1,
                UnitPrice = 100,
                GameVersion = "1.0.0"
            };
            Campaign campaign = new Campaign
            {
                Id = 1,
                CampaignName = "Kış indirimleri",
                DiscountPercent = 25
            };

            IGameService gameService = new GameManager();
            ICampaignService campaignService = new CampaignManager();
            IOrderService orderService = new OrderManager();

            gameService.Add(game);
            gameService.Update(game, "1.3.5");
            gameService.Delete(game);

          
            Console.WriteLine("--------------------");

            campaignService.Add(campaign);
            campaignService.Update(campaign);
            campaignService.Delete(campaign);

            Console.WriteLine("--------------------");

            orderService.Sale(game, gamer, campaign);
            orderService.cancelSale(game, gamer);

        }
    }
}
