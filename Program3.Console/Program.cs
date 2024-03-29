﻿using Program3.Functions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Program3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            char typeOfCounter;
            int amountOfCounters;
            List<int> maxValue = new List<int>();
            List<int> interval = new List<int>();
            List<Counter> counters = new List<Counter>();
            int threadCounter = 0;
            List<Thread> listOfThreads = new List<Thread>();

            do
            {
                System.Console.Write("Podaj typ licznika - [t]ekstowy / [l]iczbowy / [r]zymski: ");
                typeOfCounter = Char.Parse(System.Console.ReadLine().Substring(0, 1));
            } while (!(typeOfCounter.Equals('t') || (typeOfCounter.Equals('l') || (typeOfCounter.Equals('r')))));

            amountOfCounters = GetValueAsInt("amountOfCounters", typeOfCounter);

            for (int i = 0; i < amountOfCounters; i++)
            {
                System.Console.WriteLine($"Licznik {i + 1}:");
                maxValue.Add(GetValueAsInt("maxValue", typeOfCounter));
                if (typeOfCounter.Equals('t'))
                    interval.Add(GetValueAsInt("interval", typeOfCounter) * 1000);
                else
                    interval.Add(GetValueAsInt("interval", typeOfCounter));
            }

            counters = StaticMethods.GetListOfCounters(amountOfCounters, maxValue, interval);

            foreach (Counter c in counters)
            {
                threadCounter++;
                listOfThreads.Add(new Thread(() =>
                StaticMethodsForConsole.PrintCounterOnConsole(c.MaxValue, c.Interval))
                { Name = $"Licznik {threadCounter}" });
            }

            System.Console.WriteLine();

            foreach (Thread t in listOfThreads)
            {
                t.Start();
            }
            foreach (Thread t in listOfThreads)
            {
                t.Join();
            }

            System.Console.Write($"{System.Environment.NewLine}Naciśnij dowolny klawisz, aby wyjść...");
            System.Console.ReadKey();
        }

        static int GetValueAsInt(string typeOfOutput, char typeOfCounter)
        {
            string input;
            bool success = false;
            int output = -1;
            do
            {
                System.Console.Write($"Podaj {typeOfOutput}: ");
                input = System.Console.ReadLine();
                switch (typeOfCounter)
                {
                    case ('t'):
                        try
                        {
                            output = StaticMethods.WordToNumberConverter(input);
                            success = true;
                        }
                        catch (Exception)
                        {
                            output = -1;
                        }
                        break;
                    case ('l'):
                        success = Int32.TryParse(input, out output);
                        break;
                    case ('r'):
                        try
                        {
                            output = StaticMethods.RomanToNumberConverter(input);
                            success = true;
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                            output = -1;
                        }
                        break;
                }
            } while (!(success == true && output > 0));
            return output;
        }
    }
}