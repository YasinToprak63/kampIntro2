using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new PlayerVerifacitonManager());  
            Player player1 = new Player() 
            {
                FirstName = "Yasin",
                LastName = "Toprak",
                BirthYear = "2002",
              IdentityNumber = 123456,

            };

            playerManager.Record(player1);
            playerManager.Delete(player1);
            playerManager.Update(player1);


            Games games1 = new Games()
            {
                GameName = "Battlefield™ 2042",
                Price = 420,
                Publisher = "Electronic Arts",

            };
            Games games2 = new Games()
            {
                GameName = "Far Cry® 6",
                Price = 269,
                Publisher = "Ubisoft",

            };
            SalesManager salesManager = new SalesManager();
            salesManager.Sales(player1,games1);
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(games2);

            Console.ReadLine();
        }
    }
}
