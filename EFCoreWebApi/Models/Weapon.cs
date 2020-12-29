namespace EFCoreWebApi.Models
{
    public class Weapon
    {
        public int id { get; set; }

        public string Name { get; set; }

        public int HeroId { get; set; }

        public Hero Hero{ get; set; }

    }
}
