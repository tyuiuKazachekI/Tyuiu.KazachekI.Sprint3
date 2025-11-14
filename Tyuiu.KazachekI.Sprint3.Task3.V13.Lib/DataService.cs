using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            string digits = "";

            foreach (char symbol in value)
            {
                if (char.IsDigit(symbol))
                {
                    digits += symbol;
                }
            }

            if (digits.Length > 0)
            {
                return int.Parse(digits);
            }
            else
            {
                return 0;
            }
        }
    }
}