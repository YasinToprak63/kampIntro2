using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject
{
    class PlayerVerifacitonManager : IPlayerVerifacationService
    {
        public bool Verifaciton(Player player)
        {
            if (player.FirstName == "Yasin" && player.LastName == "Toprak" && player.IdentityNumber ==123456 && player.BirthYear =="2002")
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
