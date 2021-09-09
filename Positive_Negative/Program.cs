using System;

namespace Positive_Negative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada numbrit -10 kuni 10-ni
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "positive"
            //kui number on negatiivne, konsool kuvab "negative"
            //kui number on 0, siis konsool kuvab "0"

            Console.WriteLine("Please enter a number between -10 and 10");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number > 0)
            {
                Console.WriteLine("Positive.");
            }
            else if (Number < 0)
            {
                Console.WriteLine("Negative.");
            }
            else
            {
                Console.WriteLine("null");
            }
            Console.WriteLine("Have a nice day!");
            Console.ReadLine();
        }
    }
}
