using static System.Console;
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
    public class Player : Creature
    {
      //  private double weaponAttack = 1; // bare hands
       // private double attack = 10;

        public double WeaponAttack { get; set; }

        public override double AttackPower { get => base.AttackPower; set => base.AttackPower = value; }
        // почитать про сокрытие
        public void ShowProfile ()
        {
            WriteLine($"Name:{Name} attackPower:{AttackPower} CritDamageChance:{CritDamageChance} WeaponAttack:{WeaponAttack}");
            return ;
        }

        public double Attack() {
            Damage = WeaponAttack + AttackPower;
            return Damage;
        }

        public void FindFight()
        {
            Random rand = new Random(); //TODO: create enum or list or array with enemy warriors and another one with bosses
            Enemy enemy = new Enemy("Rat",40,1,200,0);
            WriteLine($"Here's ur opponent, print y/n to fight or to see the next opponent!");

        }

    }

    
}

