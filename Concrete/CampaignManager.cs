using Odev.Abstract;
using Odev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Concrete
{
    internal class CampaignManager : ICampaignServices
    {
        public void Add(Campaign campaign, Campaign date)
        {
            Console.WriteLine("{0} isimli kampanyamız {1} tarihinde eklenmiştir", campaign.CampaignName, campaign.CampaignDate);
        }
        public void Update(Campaign campaign, Campaign date)
        {
            Console.WriteLine("{0} isimli kampanyamız {1} tarihinde güncellenmiştir", campaign.CampaignName, campaign.CampaignDate);
        }
        public void Delete(Campaign campaign, Campaign date)
        {
            Console.WriteLine("{0} isimli kampanyamız {1} tarihinde silinmiştir", campaign.CampaignName, campaign.CampaignDate);
        }

        public void CampaignWithGame(Campaign campaign, Game game)
        {
            Console.WriteLine("{0} isimli oyunumuz, {1} isimli kampanyamıza eklenmiştir.", game.GameName, campaign.CampaignName);
        }
    }
}
