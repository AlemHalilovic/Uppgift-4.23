using System;

namespace Uppgift_4_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            int tal = int.Parse(Console.ReadLine());

            int Largest = tal;
            string svar = "";
            while (svar != "Nej")
            {
                Console.WriteLine("Skulle du vilja skriva in ett till heltal?(Ja/Nej)");
                svar = Console.ReadLine();

                if (svar == "Nej")
                {
                    break;

                }
                Console.WriteLine("Skriv in ditt tal här");
                int nyttHeltal  = int.Parse(Console.ReadLine());
                if (nyttHeltal  > Largest)
                {
                    Largest  = nyttHeltal;

                }
                Console.WriteLine($"Det största talet du skrev var {Largest}");
            }

        }
    }
}

