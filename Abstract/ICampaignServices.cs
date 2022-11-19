using Odev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Abstract
{
    interface ICampaignServices
    {
        void Add(Campaign campaign, Campaign date);
        void Update(Campaign campaign, Campaign date);
        void Delete(Campaign campaign, Campaign date);
        void CampaignWithGame(Campaign campaign, Game game);

    }
}
