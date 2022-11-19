

using Odev;
using Odev.Abstract;
using Odev.Concrete;
using Odev.Entity;
/*
* Abstract : İnterface'ler
* Concrete : Manager'lar
* Entity : salt dosya
* 
*/
class Program
{
    public static void Main(string[] args)
    {
        Player player1 = new Player() {PlayerId =1, PlayerName = "Aleyna", PlayerSurname = "Kaya", PlayerBirth = new DateTime(2003,1,13), TcNo = "12381204"  };
        Player player2 = new Player() {PlayerId =1, PlayerName = "Can", PlayerSurname = "Kaya", PlayerBirth = new DateTime(2001,2,01), TcNo = "1238120432"  };
        
        IPlayerServices players = new PlayerManager();
        players.Add(player1);
        players.Add(player2);

        Game game1 = new Game() { GameId = 1, GameName = "Stardew Valley", GamePrice=2.99 };
        Game game2 = new Game() { GameId = 2, GameName = "Left 4 Dead 2", GamePrice=5.99 };
        IGameServices gameServices = new GameManager();
        gameServices.Add(game1);
        gameServices.Add(game2);

        gameServices.Sales(game1, player1);
        gameServices.Sales(game2, player2);
        Campaign campaign1 = new Campaign() { CampaignId= 1, CampaignName = "Yaz Kampanyası", CampaignDate = new DateTime(2022,6,1) };
        Campaign campaign2 = new Campaign() { CampaignId= 1, CampaignName = "Kış Kampanyası", CampaignDate = new DateTime(2022,1,13) };
        ICampaignServices campaignServices = new CampaignManager();
        campaignServices.Add(campaign1, campaign1);
        campaignServices.Add(campaign2, campaign2);
        campaignServices.CampaignWithGame(campaign1, game1);

        
  

        
    }
}