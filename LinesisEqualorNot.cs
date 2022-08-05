using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_OOP_LineComparisionProblem
{
    public class LinesisEqualorNot
    {
        double lengthline1;
        double lengthline2;
        public void linesequalornot()
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
            Console.WriteLine("length of line1 is {0}", lengthline1);

            // *******CALCULATING ANOTHER LINE LENGTH*******


            Console.Write("Enter the point X3:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point X4:");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point y3:");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point y4:");
            int y4 = Convert.ToInt32(Console.ReadLine());
            double length2 = Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2);
            lengthline2 = Math.Sqrt(length2);
            Console.WriteLine("length of line2 is {0}", lengthline2);

            var result = length1.Equals(length2) ? "The two lines are equal in length" : "The two lines are unequal in length";
            Console.WriteLine(result);


        }
    }
}
