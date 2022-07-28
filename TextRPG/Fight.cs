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
            
        }
    }

    
}

