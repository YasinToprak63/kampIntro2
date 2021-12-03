using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject
{
    interface IPlayerService
    {
        void Record(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
