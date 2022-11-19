using Odev.Abstract;
using Odev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Concrete
{
    internal class GameManager : IGameServices
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} isimli oyun sistemimize eklenmiştir", game.GameName);
        }

        public void Sales(Game game, Player player)
        {
            Console.WriteLine("{0} isimli kullanıcımız, {1} isimli oyunu satın aldı!", player.PlayerName, game.GameName);
        }
    }
}
