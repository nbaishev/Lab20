using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double a);
        static void Main(string[] args)
        {
            MyDelegate myDelegate1, myDelegate2, myDelegate3;
            myDelegate1 = CircleLength;
            if (myDelegate1 != null)
            {
                Console.WriteLine("{0:F2}", myDelegate1(1));
            }
            myDelegate2 = CircleSquare;
            if (myDelegate2 != null)
            {
                Console.WriteLine("{0:F2}", myDelegate2(1));
            }
            myDelegate3 = BallVolume;
            if (myDelegate3 != null)
            {
                Console.WriteLine("{0:F2}", myDelegate3(1));
            }
            Console.ReadKey();
        }
        static double CircleLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static double CircleSquare(double r)
        {
            return Math.PI * r * r;
        }
        static double BallVolume(double r)
        {
            return (Math.PI * r * r * r * 4 / 3);
        }
    }
}
