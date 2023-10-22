using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChazovaSR.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 7.5;
            int i;
            for ( i = startValue; i<= stopValue; i++)
            {
                MultiplySeries = MultiplySeries * (Math.Pow(value, i) + (1 / (i + 1)));
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
