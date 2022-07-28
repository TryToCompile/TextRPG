/* TODO: 
 * 1) Hi, warrior, choose your name
 * 2) Fight the rat
 * 3) Add system, that allows palyer to type some commands, that will give him information about his stats, profile
 * 
 * !) Main loop - > we are using (findFight) and fighting with random guys, until we have lvlup. when we have lvledup, we have opportinity to fight boss. 
 * !) Randomly, we could have an opportunity to fight boss earlier, to have some + effects
 * 
 * 
 * ?) I will generate enemy characters randomly or i will have a list of them to use and
 * ?) For now, i think, it's better to only use a list, and later, maybe, random
 * 
 */

namespace textRPG
{
    public class Creature
    {
        private string? name = "Undefined";
        private double hpBar = 100;
        private double manapool = 100;
        private double stamina = 100;
        private double staminaForAttack = 10;
        private double armor = 10;
        private double attackPower = 10;
        private double damage = 0;
        private double critDamageChance = 10;
        private double magicArmor = 0;
        public double MagicArmor { get; set; }
        public double CritDamageChance { get; set; }
        public double Damage { get; set; }
        public double StaminaForAttack { get; set; }
        public double Armor { get; set; }
        public string? Name { get; set; }
        public double HpBar { get; set; }
        public double Manapool { get; set; }
        public double Stamina { get; set; }
        public virtual double AttackPower { get => attackPower; set => attackPower = value; } // по какой-то причине, чтобы оверрайд нормально работал, нужно виртуальное свойство определять с этими стрелочками...

    }

    
}

