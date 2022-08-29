using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elon_invensment
{
    internal class Class1
    {
        public void drive()
        {



            int battry_capasity = 100;
            int m = 0;

            Console.WriteLine("hvor mange gange skal første radiobil køre?");
            int turns = int.Parse(Console.ReadLine());
            Console.WriteLine("hvor mange gange skal anden radiobil kære?");
            int turns2 = int.Parse(Console.ReadLine());



            for (int i = 0; i < turns; i++)
            {

                m = m + 20;
                battry_capasity--;
            }
            Console.WriteLine("______________________");
            Console.WriteLine("      radiobil 1");
            Console.WriteLine("       Display");
            Console.WriteLine("______________________");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("meter  kørt " + m);
            Console.WriteLine("battri procent " + battry_capasity + "%");


            Console.WriteLine("farve grøn");
            Console.ForegroundColor = ConsoleColor.White;


            int battry_capasity2 = 100;
            int m_2 = 0;





            for (int i = 0; i < turns2; i++)
            {

                m_2 = m_2 + 20;
                battry_capasity2--;
            }
            Console.WriteLine("_____________________");
            Console.WriteLine("      radiobil 2");

            Console.WriteLine("       Display");
            Console.WriteLine("______________________");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("meter  kørt " + m_2);
            Console.WriteLine("battri procent " + battry_capasity2 + "%");
            Console.WriteLine("farve rød");
            Console.ForegroundColor = ConsoleColor.White;

            if (battry_capasity == 0)
            {
                Console.WriteLine("vil du oplade (y/n)");
                string awnser2 = Console.ReadLine();
                if (awnser2 == "y")
                {
                    Console.Clear();
                    drive();
                }

            }
            else if (battry_capasity2 == 0)
            {
                Console.WriteLine("vil du oplade (y/n)");
                string awnser2 = Console.ReadLine();
                if (awnser2 == "y")
                {
                    Console.Clear();
                    drive();
                }
            }











        }

    }
}
