using System.Linq;
using textRPG;
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
        public static void Main(string[] args)
        {


            var input = "undefined";
            Player player = new Player();


            WriteLine("!!!!To end the game just type End!!!!\n!!!!To fight just type FF or FindFight!!!!\n!!!!To see profile just type profile!!!!");
            WriteLine("Warrior!\nChoose ur name:");
            player.Name = ReadLine(); // TODO: check for exceptions with numbers or spaces or so
            WriteLine($"We are greeting u, the future god - { player.Name}!\nChoose ur weapon -> 1 - assassin's blades (10 dmg); 2 - HAMMER OF THE PURE SOUL (100 dmg) ");
            input = ReadLine();
            if (input == "1")
            {
                player.WeaponAttack = 10;
                player.CritDamageChance = 33; // TODO: add randomiser in
            }
            else if (input == "2")
            {
                player.WeaponAttack = 100;
                player.CritDamageChance = 5; // TODO: add randomiser in
            }

            // The main loop of the game
            //while (player.HpBar > 0)
            while (true)
            {
                WriteLine("----------------NewLoop is here--------------------");
                input = ReadLine();
                if (input == "FindFight" || input == "FF" || input == "ff" || input == "findfight")
                {
                    player.FindFight();
                }
                else if (input == "End" || input == "end")
                {
                    return;
                }
                else if (input == "Profile" || input == "profile")
                {
                    player.ShowProfile();
                }
            }
        }
    }

    
}

