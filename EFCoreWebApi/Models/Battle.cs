using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWebApi.Models
{
    public class Battle
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Description{ get; set; }

        public DateTime BeginDate{ get; set; }

        public DateTime EndDate{ get; set; }
    }
}
