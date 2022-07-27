using System.Linq;
using textRPG;
using static System.Console;
/* TODO: 
 * 1) Hi, warrior, choose your name
 * 2) Fight the rat
 * 3) Add system, that allows palyer to type some commands, that will give him information about his stats, profile
 */

Player player = new Player();

WriteLine("Warrior!\nChoose ur name:");
player.Name = ReadLine(); // TODO: check for exceptions with numbers or spaces or so
WriteLine($"We are greeting u, the future god - { player.Name}!\nChoose ur weapon -> 1 - assassin's blades (10 dmg); 2 - HAMMER OF THE PURE SOUL (100 dmg) ");
if (ReadLine() == "1")
{
    player.WeaponAttack = 10;
    player.CritDamageChance = 33; // TODO: add randomiser in
} else if (ReadLine() == "2")
{
    player.WeaponAttack = 100;
    player.CritDamageChance = 5; // TODO: add randomiser in
}

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
        private double armour = 10;
        private double attackPower = 10;
        public double AttackPower { get; set; }
        public double Armor { get; set; }
        public string? Name { get; set; }
        public double Hpbar { get; set; }
        public double Manapool { get; set; }
        public double Stamina { get; set; }

    }

    public class Player : Creature
    {
        private double weaponAttack;
        private double attack = weaponAttack + AttackPower;
        private double critDamageChance = 10;
        public double CritDamageChance { get; set; }
        public double Attack { get; set; }
        public double WeaponAttack { get; set; }
    }

    
    public class Rat : Creature
    {

    }

    
}

