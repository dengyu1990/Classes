using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point ori = new Point();
            (int x, int y) = ori;

  
            
            Point xM = new Point(1366, 768);
            double distance = xM.DistanceTo(ori);
            Console.WriteLine($"Distance is:{distance}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
