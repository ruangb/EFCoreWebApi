using System.Collections.Generic;

namespace EFCoreWebApi.Models
{
    public class Hero
    {
        public int id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Weapon> Weapons { get; set; }

        public IEnumerable<BattleHero> BattleHeroes { get; set; }

    }
}
