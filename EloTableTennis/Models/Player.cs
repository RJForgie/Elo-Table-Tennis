using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EloTableTennis.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public ICollection<PlayerGame> PlayerGames { get; set; }
    }
}
