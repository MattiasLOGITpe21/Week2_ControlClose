using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana, et juhilube teha
            //(tingimuseks 18 aastat vana)

            Console.WriteLine("Mis aastal sa sündisid");
            int Sünniaasta = Convert.ToInt32(Console.ReadLine());
            int Vanus = 2021 - Sünniaasta;

            if (Vanus > 18)
            {
                Console.WriteLine($"Sa oled {Vanus} aastat vana, saad juhilube teha!");
            }
            else if (Vanus < 18)
            {
                Console.WriteLine($"Sa oled {Vanus} aastat vana, ei saa juhilube teha!");
            }
            else
            {
                Console.WriteLine($"Sa oled {Vanus} aastat vana, mine juhilube tegema!");
            }
            Console.WriteLine("Kena päeva!");
            Console.ReadLine();

        }
        
    }
}
