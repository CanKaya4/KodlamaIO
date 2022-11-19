using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Entity
{
    internal class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public string TcNo { get; set; }
        public DateTime PlayerBirth { get; set; }
    }
}
