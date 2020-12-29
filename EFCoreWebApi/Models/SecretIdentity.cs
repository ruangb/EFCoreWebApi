namespace EFCoreWebApi.Models
{
    public class SecretIdentity
    {
        public int id { get; set; }

        public string RealName { get; set; }

        public string Description{ get; set; }

        public int HeroId { get; set; }

        public Hero Hero { get; set; }
    }
}
