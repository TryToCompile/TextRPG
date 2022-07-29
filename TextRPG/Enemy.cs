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
            WriteLine($"Name:{Name} attackPower:{AttackPower} CritDamageChance:{CritDamageChance} hp:{HpBar} mp:{Manapool} stamina:{Stamina}");
            return;
        } 

        public Enemy(string name, double attackPower, double critDamageChance, double hpbar,double manapool, double stamina, double staminaForAttack)
        {
            Name = name;
            AttackPower = attackPower;
            CritDamageChance = critDamageChance;
            HpBar = hpbar;
            Manapool = manapool;
            Stamina = stamina;
            StaminaForAttack = staminaForAttack;
            WriteLine("bzz...Enemy Created...bzzz.....stats:");
            ShowEnemyProfile();
        }

        public void Attack(Player player)
        {
            Damage = AttackPower;
            if (Stamina >= StaminaForAttack)
            {
       //         WriteLine($"DEBUG enemy.attack stamina{Stamina} StAttack{StaminaForAttack}");
                Stamina -= StaminaForAttack;
                player.HpBar -= Damage - player.Armor;
            } else 
            {
                WriteLine($"{Name} have not enough stamina:{Stamina}");
            }
            WriteLine($"Player Hp:{player.HpBar}; Player Stamina:{player.Stamina - player.StaminaForAttack}");
            return;
        }

        public void MagicAttack(Player player)
        {
            Damage = MagicDamage;
            if (Stamina >= StaminaForAttack)  // TODO: change stamina for mp
            {
                Stamina -= StaminaForAttack;
                player.HpBar -= Damage - player.MagicArmor;

            }
            WriteLine($"Player Hp:{player.HpBar}; Player Stamina:{player.Stamina}");
            return;
        }


    }

    
}

