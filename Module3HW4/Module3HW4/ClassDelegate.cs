using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4
{
    public class ClassDelegate
    {
        private double _sum = 0.0;

        public event Func<double, double, double> EventSum;

        public double Sum
        {
            get
            {
                return _sum;
            }
        }

        public double SumFunc(double x, double y) => x + y;

        public double SumResult(int x, int y)
        {
            Result(() =>
            {
                _sum += EventSum.Invoke(x, y);
            });

            return _sum;
        }

        public void Result(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
