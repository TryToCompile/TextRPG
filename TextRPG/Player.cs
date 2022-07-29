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
        private double magicAttack = 0;
        private double experience = 0;
        private double expK = 5;
        private double level = 0;
        
        public double Level { get; set; }
        public double ExpK { get; set; }
        public double Experience { get; set; }
        public double MagicDamage { get; set; }
        public double WeaponAttack { get; set; }

        public override double AttackPower { get => base.AttackPower; set => base.AttackPower = value; }
        // почитать про сокрытие


        public Player(double hp, double mp, double stamina, double staminaForAttack, double maxHP)
        {
            HpBar = hp;
            Manapool = mp;
            Stamina = stamina;
            StaminaForAttack = staminaForAttack;
            MaxHP = maxHP;
        }
        public void ShowProfile ()
        {
            WriteLine($"Name:{Name} level:{Level} attackPower:{AttackPower} CritDamageChance:{CritDamageChance} \n" +
                $"WeaponAttack:{WeaponAttack} Hp:{HpBar} mp:{Manapool} stamina:{Stamina}\n " +
                $"experience:{Experience} maxHP:{MaxHP} armor:{Armor}");
            return ;
        }
        public void LevelUp(Player player, Loop loop)
        {
            player.AttackPower += player.Level + loop.GetRandomNumber(1.1,2.2);
            player.MaxHP += loop.GetRandomNumber(10,30);
            player.HpBar = MaxHP;
            player.Armor += loop.GetRandomNumber(1,40);
            WriteLine($"                  level UP!!!!!\n AttackPower now:{player.AttackPower}, \t" +
                      $"MaxHP now is {MaxHP} and hpBAR now is {HpBar}");
            player.Level++;
            player.Experience -= 100;
            return;
        }
        public void GetExperience(Player player, Enemy enemy,Loop loop)
        {
            WriteLine("DEBUG!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            player.Experience += ExpK*(enemy.HpBar + enemy.Armor) / (player.AttackPower + player.WeaponAttack);
            player.Stamina = 100;
            player.HpBar = player.MaxHP;
            if (player.Experience >= 100)
            {
                LevelUp(player,loop);
            }
            return;
        }

        public void GetExperience(Player player)
        {

            return;
        }

        public void Attack(Enemy enemy) {
            Damage = WeaponAttack + AttackPower;
            if( Stamina >= StaminaForAttack )
            {
        //        WriteLine($"DEBUG player.attack stamina{Stamina} StAttack{StaminaForAttack}");
                Stamina -= StaminaForAttack;
                enemy.HpBar -= Damage - enemy.Armor;

            } else
            {
                WriteLine($"{Name} have not enough stamina:{Stamina}");
            }
            WriteLine($"Enemy Hp:{enemy.HpBar}; Enemy Stamina:{enemy.Stamina - enemy.StaminaForAttack}");
            return;
        }

        public void MagicAttack(Enemy enemy)
        {
            Damage = MagicDamage;
            if (Stamina > StaminaForAttack)
            {
                Stamina -= StaminaForAttack;
                enemy.HpBar -= Damage - enemy.MagicArmor;

            }
            WriteLine($"Enemy Hp:{enemy.HpBar}");
            return;
        }

        public void FindFight()
        {
            

        }

    }

    
}

