using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_OOP_LineComparisionProblem
{
    public class calculatinglinelength
    {
        double lengthline1;
        double lengthline2;
        public void Calculatinglinelength()
        {
            Console.Write("Enter the point X1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point X2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point Y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point Y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length1 = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            lengthline1 = Math.Sqrt(length1);
            Console.WriteLine("length of line is {0}", lengthline1);

        }
    }
}

