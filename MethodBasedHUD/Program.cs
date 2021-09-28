using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodBasedHUD
{
    class Program
    {
        static string name; 
        static float score;
        static int health;
        static int lives;
        static void TakeDamage(int damage)
        {
            health = health - damage;
        }
        static void GetKill()
        {
            score = score + 50;
        }
        static void die()
        {
            lives = lives - 1;
        }
        
        //attempt to add a multiplier 
        //static void combo()
        //{
            
        //}
        

        static void ShowHUD()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("=======================");
            Console.WriteLine("Player - " + name);
            Console.WriteLine("Health - " + health);
            Console.WriteLine("Lives - " + lives);
            Console.WriteLine("Points - " + score);
            Console.WriteLine("=======================");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            //initialize
            name = "Den";
            health = 100;
            lives = 3;
            score = 0;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Very Mega Epic TBRPG That Is Definetly NOT Hardcoaded More Than It Needs To Be");
            Console.WriteLine("From the creators of 'learning to code from a professional named DENISON PERCEY' ");
            Console.WriteLine(" ");
            Console.ResetColor();
            Console.ReadKey();

            //gameplay starts 
            Console.WriteLine(" ");
            Console.WriteLine("you find yourself inexplicably standing in a field surrounded by enemies");
            Console.WriteLine("you think to yourself:");
            Console.WriteLine("'this looks like a reason for someone to demonstrate their understanding of coding methods' ");
            Console.WriteLine(" ");
            Console.ReadKey();

            ShowHUD();
            Console.ReadKey();

            Console.WriteLine(" ");
            Console.WriteLine("While pondering the meaning of this hellscape of a universe, a non-descript enemy has taken you by suprise!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            Console.WriteLine("You take 20 points of damage!!!");
            Console.ResetColor();
            Console.WriteLine(" ");

            Console.ReadKey();

            TakeDamage(20);
            ShowHUD();
            Console.ReadKey();
            Console.WriteLine(" ");

            Console.WriteLine("You retaliate with a swing of your trusty sword that was most definetly there before Denison got to this line of code");
            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You get a Kill!!!");
            Console.WriteLine("50pts");
            Console.WriteLine(" ");
            Console.ResetColor();
            Console.ReadKey();

            GetKill();
            Console.WriteLine(" ");
            ShowHUD();
            Console.WriteLine(" ");

            Console.ReadKey();

            Console.WriteLine("you manage to take out 2 more enemies and it looked SO COOL trust me");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You get 2 Kills!!!");
            Console.WriteLine("100pts");
            Console.WriteLine(" ");
            Console.ResetColor();
            Console.ReadKey();

            GetKill();
            GetKill();

            Console.WriteLine(" ");
            ShowHUD();
            Console.WriteLine(" ");
            Console.ReadKey();

            Console.WriteLine("The enemies suddenly dog pile you! You're suffocating in a sea of non-descript horror!!!!!!");

            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You take a whopping 70 points of damage!!!");
            Console.WriteLine(" ");
            Console.ResetColor();
            Console.ReadKey();

            TakeDamage(70);

            Console.WriteLine(" ");
            ShowHUD();
            Console.WriteLine(" ");

            Console.ReadKey();

            Console.WriteLine("with your dieing breath you attempt to perform a Legend Of Zelda-esque spin attack!");
            Console.WriteLine("You must have rolled a nat-20 because you manage to Kill 4 more!");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You get 4 Kills!!!");
            Console.WriteLine("200pts");
            Console.WriteLine(" ");
            Console.ResetColor();
            Console.ReadKey();

            GetKill();
            GetKill();
            GetKill();
            GetKill();

            Console.WriteLine(" ");
            ShowHUD();
            Console.WriteLine(" ");
            Console.ReadKey();

            Console.WriteLine("alas your story has come to an end");
            Console.WriteLine("the monsters have finally overpowered you");
            Console.WriteLine("you meet your God as an enemy pokes you, depleteing your remaining 10 HP");
            Console.WriteLine(" ");
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You take 10 points of damage");
            Console.WriteLine("YOU HAVE DIED");
            Console.WriteLine(" ");
            Console.ResetColor();

            die();
            Console.ReadKey();

            Console.WriteLine(" ");
            ShowHUD();
            Console.WriteLine(" ");

            Console.WriteLine("Wait you still have 2 lives left");
            Console.WriteLine("and we all know the game doesnt end when you run out of lives");
            Console.WriteLine("You're trapped in purgatory forever");
            Console.WriteLine(" ");
            Console.WriteLine("THE END");

            Console.ReadKey(true);
        }

        
    }
}
