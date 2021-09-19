using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutajal sisestada tema lemmik v@rv;
            //kui kasutaja sisestab punane, konsol kuvab 'oled romantiline';
            //kui kasutaja sisestab sinine, konsol kuvab 'oled tookas';
            //roheline, loodus s6ber;
            //muud- oled {user color} ykssarvik;

            Console.WriteLine("Sisesta oma lemmik v@rv:");
            string UserColor = Console.ReadLine();

            if(UserColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if (UserColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if (UserColor == "roheline")
            {
                Console.WriteLine("Oled Ecoaktivist.");
            }

            else
            {
                Console.WriteLine($"Oled {UserColor} ükssarvik ");

            }

            Console.WriteLine("good day!");
        }
    }
}
