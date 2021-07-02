using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
     public class TriangleSolver
     {
            private int t1;
            private int t2;
            private int t3;
            public TriangleSolver()
            {
                t1 = 1;
                t2 = 1;
                t3 = 1;
            }
            public TriangleSolver(int t1, int t2, int t3)
            {
                this.t1 = t1;
                this.t2 = t2;
                this.t3 = t3;
            }
            public static string Analyze()
            {
                string result = string.Empty;
                Console.Write("Input side 1 of triangle:");
                int t1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 2 of triangle:");
                int t2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 3 of triangle:");
                int t3 = Convert.ToInt32(Console.ReadLine());

                    if (t1 + t2 > t3 && t1 + t3 > t2 && t2 + t3 > t1)
                    {
                        if (t1 == t2 && t1 == t3)
                        {
                             result = "Equilateral triangle";
                        }

                        else  if (t1 == t2 || t1 == t3 || t2 == t3)
                        {
                             result = "Isosceles triangle";
                        }
                        else
                        {
                            result = "Scalene triangle";
                        }
                    }
                    else
                    {
                            result = "Does not form a triangle";
                    }
                     return result;
            }
     } 
}
