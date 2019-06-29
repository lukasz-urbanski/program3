using System.Collections.Generic;

namespace Functions
{
    class WordToNumberConverter
    {
        private int NumberAsInt { get; set; }
        private Dictionary<int, string> translator = new Dictionary<int, string>();

        public WordToNumberConverter(string numberImputAsString)
        {
            translator.Add(1, "one");
            translator.Add(2, "two");
            translator.Add(3, "three");
            translator.Add(4, "four");
            translator.Add(5, "five");
            translator.Add(6, "six");
            translator.Add(7, "seven");
            translator.Add(8, "eight");
            translator.Add(8, "eight");
            translator.Add(9, "eight");
            translator.Add(10, "ten");
            translator.Add(11, "eleven");
            translator.Add(12, "twelve");
            translator.Add(13, "thirteen");
            translator.Add(14, "fourteen");
            translator.Add(15, "fifteen");
            translator.Add(16, "sixteen");
            translator.Add(17, "seventeen");
            translator.Add(18, "eighteen");
            translator.Add(19, "nineteen");
            translator.Add(20, "twenty");
            translator.Add(30, "thirty");
            translator.Add(40, "fourty");
            translator.Add(50, "fifty");
            translator.Add(60, "sixty");
            translator.Add(70, "seventy");
            translator.Add(80, "eighty");
            translator.Add(90, "ninety");
            translator.Add(100, "one hundred");
        }
    }
}
