using System.Collections.Generic;
using System;

namespace Program3.Functions
{
    public static class StaticMethods
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
            string[] numberImputAsStringSplitted = numberImputAsString.Split(' ');

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

        public static int ConvertSingleRomanChar(char inputChar)
        {
            switch (inputChar)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                default:
                    throw new ArgumentException($"\tBłąd: \"{inputChar.ToString()}\" nie jest prawidłową cyfrą rzymską. Cezar jest rozczarowany.");
            }
        }

        public static int RomanToNumberConverter(string numberImputAsString)
        {
            numberImputAsString = numberImputAsString.ToUpper();
            int result = 0;

            for (int currentChar = 0; currentChar < numberImputAsString.Length; currentChar++)
            {
                if (currentChar < numberImputAsString.Length - 1) //if this is not the last char yet
                {
                    //check if next char forms a combo

                    string combo = numberImputAsString[currentChar].ToString() + numberImputAsString[currentChar + 1].ToString();
                    switch (combo)
                    {
                        case "IX":
                            result += 9;
                            currentChar++;
                            break;
                        case "IV":
                            result += 4;
                            currentChar++;
                            break;
                        case "XL":
                            result += 40;
                            currentChar++;
                            break;
                        case "XC":
                            result += 90;
                            currentChar++;
                            break;
                        default: //no. it's not a combo
                            result += ConvertSingleRomanChar(numberImputAsString[currentChar]);
                            break;
                    }
                }
                else //it is the last char
                {
                    result += ConvertSingleRomanChar(numberImputAsString[currentChar]);
                }
            }
            return result;
        }

    }
}