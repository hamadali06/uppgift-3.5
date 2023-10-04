using System;
namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            string tal1 = Console.ReadLine();
            int tal11 = Convert.ToInt32(tal1);
            Console.WriteLine("Skriv ett till tal");
            string tal2 = Console.ReadLine();
            int tal22 = Convert.ToInt32(tal2);
            int addition = tal22 + tal11;
            int subtraktion = tal22 - tal11;
            int multiplikation = tal22 * tal11;
            int division = tal22 / tal22;
            Console.WriteLine("Välj ett räknemetod");
            Console.WriteLine("1. addiion");
            Console.WriteLine("2. subtraktion");
            Console.WriteLine("3. multiplikation");
            Console.WriteLine("4. division");
            string svar = Console.ReadLine();
            int svar1 = Convert.ToInt32(svar);
            Console.Clear();
            switch (svar1)
            {
                case 1:
                    Console.WriteLine("svar : " + addition);
                    break;
                    case 2:
                    Console.WriteLine("svar : " +  subtraktion);
                    break;
                    case 3:
                    Console.WriteLine("svar : " + multiplikation);
                    break;
                    case 4:
                    Console.WriteLine("svar : " + division);
                    break;
                    default: Console.WriteLine("Du valde ingen av alternativen");
                    break;
            }
        }
    }
} 