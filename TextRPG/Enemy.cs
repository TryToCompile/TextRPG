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
    public class Enemy : Creature
    {
        public void ShowEnemyProfile()
        {
            WriteLine($"Name:{Name} attackPower:{AttackPower} CritDamageChance:{CritDamageChance} hp:{HpBar} mp:{Manapool}");
            return;
        } 

        public Enemy(string name, double attackPower, double critDamageChance, double hpbar,double manapool)
        {
            Name = name;
            AttackPower = attackPower;
            CritDamageChance = critDamageChance;
            HpBar = hpbar;
            Manapool = manapool;
            ShowEnemyProfile();
        }

        public double Attack(Player player)
        {
            Damage = AttackPower;
            if (Stamina > StaminaForAttack)
            {
                Stamina -= StaminaForAttack;
                player.HpBar -= Damage - player.Armor;

            } else if (Stamina < StaminaForAttack)
            {
                WriteLine($"{Name} have not enough stamina:{Stamina}");
            }
            return player.HpBar;
        }

        public double MagicAttack(Player player)
        {
            Damage = MagicDamage;
            if (Stamina > StaminaForAttack)
            {
                Stamina -= StaminaForAttack;
                player.HpBar -= Damage - player.MagicArmor;

            }
            return player.HpBar;
        }


    }

    
}

