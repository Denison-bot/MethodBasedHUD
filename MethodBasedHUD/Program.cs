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
        static int score;
        static int health;
        static float xp;
        static int lives;
        static int deaths;
        static void ShowHUD()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Player - " + name);
            Console.WriteLine("Health - " + health);
            Console.WriteLine("Lives - " + lives);
            Console.WriteLine("Experience - " + xp);
            Console.WriteLine("=======================");
        }
        static void Main(string[] args)
        {

            ShowHUD();

            Console.ReadKey(true);
        }

        
    }
}
