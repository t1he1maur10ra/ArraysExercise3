using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create the array and populate it at the 5 maori words i have chosen*/
            string[] maori = { "Kia ora", "Nau mai", "Aroha", "Hui", "Koha" };
            /*Array of the english translations*/
            string[] english = { "Hello", "Welcome", "Love", "Meeting", "Gift" };


            Console.WriteLine("******************************************");
            Console.WriteLine("************* Translator App *************");
            Console.WriteLine("******************************************");
            Console.WriteLine("This app can translate the following words:");

            for (int i = 0; i < maori.Length; i++)
            {
                Console.WriteLine($"{i+1}. {english[i]}");
            }
            Console.Write("\nWhich word would you like translated to Maori: ");

            /*Take in the users input as an int*/
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{english[input-1]} translated into maori is: {maori[input-1]}");

            Console.WriteLine("\nThankyou for using this app, press ENTER to quit...");
            Console.ReadLine();
        }
    }
}
