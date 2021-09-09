using System;

namespace Control_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //kui kasutaja on vanem kui 18, siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja on noorem kui 18, siis konsoolis kuvatakse "oled liiga noor"
            //kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18"

            Console.WriteLine("Kui vana sa oled?");
            int Vanus = Convert.ToInt32(Console.ReadLine());

            if (Vanus > 18)
            {
                Console.WriteLine("Oled piisavalt vana.");
                
            }

            else if (Vanus < 18)
            {
                Console.WriteLine("Oled liiga noor!");
                
            }
            else
            {
                Console.WriteLine("Oledki 18!");
            }

            Console.WriteLine("Kena päeva!");
            Console.ReadLine();
            
        }
    }
}
