using System.Collections.Generic;

namespace Program3.Functions
{
    public static class StaticMethods //not really a proper name for a class, and also not really an example of 'encapsulation'. 
    //works fine, and is quite tidy, but imagine that your program is larger and you have 299 methods here.
    //Then it would become sort of a master class that works on every aspect of the program..
    {
        public static List<Counter> GetListOfCounters(int amountOfCounters, List<int> maxValue, List<int> interval)
        {
            List<Counter> listOfCounters = new List<Counter>();
            for (int i = 0; i < amountOfCounters; i++)
            {
                listOfCounters.Add(new Counter(maxValue[i], interval[i]));
            }
            return listOfCounters;
        }
        public static int WordToNumberConverter(string numberImputAsString)
        {
            Dictionary<string, int> translator = new Dictionary<string, int>();
            int resultOfThisMethod = 0;
            string[] numberImputAsStringSplitted = numberImputAsString.Split(' '); //does it support 'twenty-seven'? (correct spelling)

            translator.Add("one", 1);
            translator.Add("two", 2);
            translator.Add("three", 3);
            translator.Add("four", 4);
            translator.Add("five", 5);
            translator.Add("six", 6);
            translator.Add("seven", 7);
            translator.Add("eight", 8);
            translator.Add("nine", 9);
            translator.Add("ten", 10);
            translator.Add("eleven", 11);
            translator.Add("twelve", 12);
            translator.Add("thirteen", 13);
            translator.Add("fourteen", 14);
            translator.Add("fifteen", 15);
            translator.Add("sixteen", 16);
            translator.Add("seventeen", 17);
            translator.Add("eighteen", 18);
            translator.Add("nineteen", 19);
            translator.Add("twenty", 20);
            translator.Add("thirty", 30);
            translator.Add("fourty", 40);
            translator.Add("fifty", 50);
            translator.Add("sixty", 60);
            translator.Add("seventy,", 70);
            translator.Add("eighty", 80);
            translator.Add("ninety", 90);
            translator.Add("hundred", 100);

            for (int i = numberImputAsStringSplitted.Length - 1; i >= 0; i--)
            {
                try
                {
                    resultOfThisMethod += translator[numberImputAsStringSplitted[i]];
                }
                catch (System.Exception)
                {
                    return -1;
                }
                
            }
            return resultOfThisMethod;
        }
    }
}