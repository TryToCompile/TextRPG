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
    public partial class Loop
    {
       // public class Fight {
       //     public Fight(Player player, Enemy enemy)
       //     {
       //         player.ShowProfile();
       //         WriteLine("VS\n");
       //         enemy.ShowEnemyProfile();
       //         
       //     }
       // }

        public void Fight(Player player, Enemy enemy)
        {
            player.ShowProfile();
            WriteLine("VS");
            enemy.ShowEnemyProfile();
            // TODO: add randomiser for queue of the first attack
            // FIGHT LOOP
            while (true)
            {
                if (player.HpBar <= 0)
                {
                    WriteLine($"{player.Name} hp is < 0. DEATH");
                    break;
                }
                else if (enemy.HpBar <= 0)
                {
                    WriteLine($"{enemy.Name} hp is < 0. WIN? "); // TODO: add last chance to kill our player with 0.001% probability, while enemy has < 0 hps
                }
                WriteLine("Continue fight?.. y/n to continue or flee");
                var input = ReadLine();
                if (input == "n")
                {
                    break;
                } else if (input == "y")
                {
                //    WriteLine($"player.stamina:{player.Stamina}; enemy.stamina{enemy.Stamina}");
                    WriteLine("Ok!Next step ->");// TODO: add variants of attacks (magick, strong/weak attack, or block)
                    player.Attack(enemy);
                    enemy.Attack(player);
                }
                
            }
        }
    }

    
}

