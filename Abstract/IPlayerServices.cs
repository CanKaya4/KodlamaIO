using Odev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Abstract
{
    internal interface IPlayerServices
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
