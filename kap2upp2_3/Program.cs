// int sum = 300 + (1 * km) + ((antal dagar - 1) * 500)
//          start   1kr/km       minus första dagen
using System;
namespace kap2upp2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Välkommen till vår biluthyrningsfirma");
            Console.WriteLine("Hur många dagar vill du hyra en bil? (Startavgift 300kr):");
            string antaldagar = Console.ReadLine();
            int intdagar = int.Parse(antaldagar);
            Console.WriteLine("Hur många kilometer kommer du att köra?:");
            string antalkm = Console.ReadLine();
            double doublekm = double.Parse(antalkm);
            double sum = 300 + (1 * doublekm) + ((intdagar - 1) * 500);
            Console.WriteLine("Det kommer att kosta " + sum + "kr " + "att hyra bilen");
        }
    }
}