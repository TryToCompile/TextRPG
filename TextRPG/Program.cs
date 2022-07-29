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
        public double GetRandomNumber(double min, double max)
        {
            Random rand = new Random();
            return rand.NextDouble() * (max - min) + min;
        }
        public static void Main(string[] args)
        {
             double GetRandomNumber(double min, double max)
            {
                Random rand = new Random();
                return rand.NextDouble() * (max - min) + min;
            }


            var input = "undefined";
            Player player = new Player(100, 0, 100, 10,100); // Вероятно, нужно привести типы, да, разобраться с наследованием этих классов
            Loop loop = new Loop();
            //           player.HpBar = 100; // КОСТЫЛЬ
            //           player.Stamina = 100;
            //           player.StaminaForAttack = 10;
            WriteLine("!!!!To end the game just type End!!!!\n!!!!To fight just type FF or FindFight!!!!\n!!!!To see profile just type profile!!!!");
            WriteLine("Warrior!\nChoose ur name:");
            try
            {
                player.Name = ReadLine(); // TODO: check for exceptions with numbers or spaces or so
                if (player.Name.Length <= 2)
                {
                    throw new Exception("Length of the name should be more than 2!");
                }
            } catch (Exception ex)
            {
                WriteLine($"Ошибка: {ex.Message}");
                Main(args);
            }

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

                WriteLine("FF - new fight, profile - see stats, end - end of the game");
                input = ReadLine();
                if (input == "FindFight" || input == "FF" || input == "ff" || input == "findfight")
                {
                    // player.FindFight();
                    Random rand = new Random(); //TODO: create enum or list or array with enemy warriors and another one with bosses
                    Enemy enemy = new Enemy("Rat", 40, 1, 200, 0, 40, 20);
                    WriteLine($"Here's ur opponent, print y/n to fight or to see the next opponent!");
                    input = ReadLine();
                    if (input == "fight" || input == "Fight" || input == "y")
                    {
                        loop.Fight(player, enemy,loop);
                    } else if (input == "n")
                    {
                        WriteLine("We have no other opponents to u.");
                        return;
                    }
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

