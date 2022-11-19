using Odev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Abstract
{
    internal interface IGameServices
    {
        void Add(Game game);
        void Sales(Game game, Player player);
       
    }
}
