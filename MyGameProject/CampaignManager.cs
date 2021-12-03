using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Games games)
        {
            Console.WriteLine("Yeni Kampanya " + games.GameName +  " %50 İndirimli" );
            Console.WriteLine("Kampanya Fiyatı : " +  games.Price / 2 );
        }

        public void Delete(Games games)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Games games)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
