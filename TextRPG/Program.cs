using System.Linq;

namespace textRPG
{
    public class Creature
    {
        public string? name = "Undefined";
        public double hpbar = 100;
        public double manapool = 100;
        public double stamina = 100;
        public string Name { get; set; }
        public double Hpbar { get; set; }
        public double Manapool { get; set; }
        public double Stamina { get; set; }

    }

    public class Player : Creature
    {

    }
}