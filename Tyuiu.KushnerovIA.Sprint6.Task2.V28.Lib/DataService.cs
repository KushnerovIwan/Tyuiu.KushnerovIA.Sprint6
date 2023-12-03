using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KushnerovIA.Sprint6.Task2.V28.Lib
{
    public class DataService : ISprint6Task2V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            double y;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3*x-1 == 0) y = 0;
                else y = (Math.Sin(x)- 2*x)/(double)(3*x-1)+Math.Sin(x)-3*x+2;
                res[cnt] = Math.Round(y, 2);
                cnt++;
            }
            return res;
        }
    }
}