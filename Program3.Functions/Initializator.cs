using System;
using System.Collections.Generic;

namespace Program3.Functions
{
    static public class Initializator
    {
        public static List<Counter> GetListOfCounters()
        {
            //Console.Write("Podaj typ licznika: ");
            //string counterType = "liczbowy";
            Console.Write(Environment.NewLine + "Podaj ilość liczników: ");
            int counterCount = Int32.Parse(Console.ReadLine());
            List<Counter> listOfCounters = new List<Counter>();
            for (int i = 0; i < counterCount; i++)
            {
                Console.WriteLine($"{Environment.NewLine}Licznik nr {i + 1}");
                Console.Write("Podaj maksymalną wartość odlicznia: ");
                int maxValue = Int32.Parse(Console.ReadLine());
                Console.Write("Podaj liczbę sekund intewału: ");
                int interval = Int32.Parse(Console.ReadLine()) * 1000;
                listOfCounters.Add(new Counter(maxValue, interval));
            }
            return listOfCounters;
        }
    }
}