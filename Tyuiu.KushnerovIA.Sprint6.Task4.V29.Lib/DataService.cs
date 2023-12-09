using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KushnerovIA.Sprint6.Task4.V29.Lib
{
    public class DataService : ISprint6Task4V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] array = new double[len];
            int count = 0;
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (2*x-3)/(double)(Math.Cos(x)-2*x) + 5*x - 6;
                y = Math.Round(y, 2);
                if (Math.Cos(x) - 2 * x == 0)
                {
                    y = 0;
                }
                array[count] = y;
                count++;
            }
            return array;
        }
    }
}
