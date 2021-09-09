using System;

namespace WhenWereYouBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanuse
            //programm kuvab kasutaja vanuse

            Console.WriteLine("Mis aastal sa sündisid?");
            int Sünniaasta = Convert.ToInt32 (Console.ReadLine());
            int Vanus = 2021 - Sünniaasta;

            Console.WriteLine($"Sa oled {Vanus} aastat vana.");
            Console.ReadLine();
            





        }
    }
}
