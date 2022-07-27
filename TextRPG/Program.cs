using System.Linq;
using textRPG;
using static System.Console;
/* TODO: 
 * 1) Hi, warrior, choose your name
 * 2) Fight the rat
 * 3) Add system, that allows palyer to type some commands, that will give him information about his stats, profile
 */
var input = "undefined";
Player player = new Player();

WriteLine("Warrior!\nChoose ur name:");
player.Name = ReadLine(); // TODO: check for exceptions with numbers or spaces or so
WriteLine($"We are greeting u, the future god - { player.Name}!\nChoose ur weapon -> 1 - assassin's blades (10 dmg); 2 - HAMMER OF THE PURE SOUL (100 dmg) ");
input = ReadLine();
if (input == "1")
{
    player.WeaponAttack = 10;
    player.CritDamageChance = 33; // TODO: add randomiser in
} else if (input == "2"
{
    player.WeaponAttack = 100;
    player.CritDamageChance = 5; // TODO: add randomiser in
}
WriteLine(player.ShowProfile());
WriteLine(player.Attack());


while (player.Hpbar > 0)
{

}


namespace textRPG
{
    public class Creature
    {
        private string? name = "Undefined";
        private double hpbar = 100;
        private double manapool = 100;
        private double stamina = 100;
        private double staminaForAttack = 10;
        private double armour = 10;
        private double attackPower = 10;
        private double damage = 0;
        public double Damage { get; set; }
        public double StaminaForAttack { get; set; }
        public virtual double AttackPower { get => attackPower; set => attackPower = value; } // по какой-то причине, чтобы оверрайд нормально работал, нужно виртуальное свойство определять с этими стрелочками...
        public double Armor { get; set; }
        public string? Name { get; set; }
        public double Hpbar { get; set; }
        public double Manapool { get; set; }
        public double Stamina { get; set; }

    }

    public class Player : Creature
    {
      //  private double weaponAttack = 1; // bare hands
       // private double attack = 10;
        private double critDamageChance = 10;
        public double WeaponAttack { get; set; }
        public double CritDamageChance { get; set; }

        public override double AttackPower { get => base.AttackPower; set => base.AttackPower = value; }
        // почитать про сокрытие
        public string ShowProfile ()
        {
            return $"Name:{Name} attackPower:{AttackPower} CritDamageChance:{CritDamageChance} WeaponAttack:{WeaponAttack}";
        }

        public double Attack() {
            Damage = WeaponAttack + AttackPower;
            return Damage;
        }

    }

    
    public class Rat : Creature
    {

    }

    
}

