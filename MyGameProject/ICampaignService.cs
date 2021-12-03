using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject
{
    interface ICampaignService
    {
        void Add(Games games);
        void Delete(Games games);
        void Update(Games games);

    }
}
