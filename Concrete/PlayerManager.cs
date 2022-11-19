using Odev.Abstract;
using Odev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Concrete
{
    internal class PlayerManager : IPlayerServices
    {
        public void Add(Player player)
        {
            Console.WriteLine("{0} isimli oyuncu sistemimize eklenmiştir.", player.PlayerName);
        }
        public void Update(Player player)
        {
            Console.WriteLine("{0} isimli oyuncu sistemimizde güncellenmiştir.", player.PlayerName);
        }
        public void Delete(Player player)
        {
            Console.WriteLine("{0} isimli oyuncu sistemimizden silinmiştir.", player.PlayerName);
        }

       
    }
}
