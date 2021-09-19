using System;

namespace PersonalityTestSwitch
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
            string UserColor = Console.ReadLine().ToLower();

            //Suur t@ht v6ib olla;


            switch (UserColor)

            {
                case "punane":
                    Console.WriteLine("Oled Kommunist");
                    break;
                case "sinine":
                    Console.WriteLine("Oled Liberaal");
                    break;
                case "roheline":
                    Console.WriteLine("Oled EcoAktivist");
                    break;
                default:
                    Console.WriteLine($"Oled {UserColor} ykssarvik");
                    break;
            }


            Console.WriteLine("GOOD BUY, TOVARISH");

        }
    }
}
