using System;
using System.Collections.Generic;

namespace Program3.Functions
{
    static class StaticMethodsForWfa
    {
        static public bool ValidateInput(List<string> textBoxesToBeChecked, string selectedButton)
        {
            if (selectedButton.Equals("tekstowy"))
            {
                foreach (string textBox in textBoxesToBeChecked)
                {
                    if (StaticMethods.WordToNumberConverter(textBox) == -1)
                        return false;
                }
                return true;
            }
            if (selectedButton.Equals("liczbowy"))
            {
                int temp;
                foreach (string textBox in textBoxesToBeChecked)
                {
                    if (!Int32.TryParse(textBox, out temp))
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}