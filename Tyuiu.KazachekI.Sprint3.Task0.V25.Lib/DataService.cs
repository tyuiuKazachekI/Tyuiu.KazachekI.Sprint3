using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {

            public double GetSumSeries(int value, int startValue, int stopValue)
            {
                double sum = 0;

                for (int i = startValue; i <= stopValue; i++)
                {
                    double denominator = 1 + Math.Pow(value, i);
                    double term = Math.Pow(4.0 / denominator, i);
                    sum += term;
                }

                return Math.Round(sum, 2);
            }
        }
    }