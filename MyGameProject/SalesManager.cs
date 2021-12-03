using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject
{
    class SalesManager : ISalesService
    {  
        public void Sales(Player player, Games games)
        {
            Console.WriteLine(player.FirstName + " : "+ games.GameName + " oyununu satın aldı");
            Console.WriteLine("Ücret : " + games.Price);
            Console.WriteLine("Yayıncı : " + games.Publisher);
        }
    }
}
