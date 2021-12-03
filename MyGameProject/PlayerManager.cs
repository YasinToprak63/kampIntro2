using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject
{
    class PlayerManager : IPlayerService
    {
        IPlayerVerifacationService _playerVerifacationService;
        public PlayerManager(IPlayerVerifacationService playerVerifacationService)
        {
            _playerVerifacationService = playerVerifacationService;
        }

        public void Delete(Player player)
        {
             Console.WriteLine("Player Deleted");          
        }

        public void Record(Player player)
        {
            if (_playerVerifacationService.Verifaciton(player) == true)
            {
                Console.WriteLine("Player Recorded");
            }
            else
            {
                Console.WriteLine("Player could not be verified");
            }
            
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player Updated");
        }
    }
}
