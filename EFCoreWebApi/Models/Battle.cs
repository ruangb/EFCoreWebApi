using System;
using System.Collections.Generic;

namespace EFCoreWebApi.Models
{
    public class Battle
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Description{ get; set; }

        public DateTime BeginDate{ get; set; }

        public DateTime EndDate{ get; set; }

        public IEnumerable<BattleHero> BattleHeroes { get; set; }
    }
}
