using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWebApi.Models
{
    public class Hero
    {
        public int id { get; set; }

        public string Name { get; set; }

        public int BattleId{ get; set; }

        public Battle Battle{ get; set; }
    }
}
