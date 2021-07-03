using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            choice = UserMenuSelection();

            while (choice != 2)
            {

                switch (choice)
                {
                    case 1:
                        int t1 = 0, t2 = 0, t3 = 0;
                        Console.WriteLine($"Triangle is {TriangleSolver.Analyze(t1,t2,t3)}");
                      
                        Console.ReadLine();
                        break;

                    default:
                        break;
                }

                choice = UserMenuSelection();

            }
        }
        public static int UserMenuSelection()
        {
            string MyInput = "";
            bool validSelection = false;
            int MyInpuInt;

            while (validSelection == false)
            {
                Console.WriteLine("1.Enter Triangle Dimensions");
                Console.WriteLine("2.Exit\n");

                Console.WriteLine("Please select an option:\n");

                MyInput = Console.ReadLine();
                MyInpuInt = int.Parse(MyInput);

                if (MyInpuInt <= 0 || MyInpuInt > 2)
                {
                    Console.WriteLine("Chosse correct option\n");
                }
                else
                {
                    validSelection = true;
                }
            }

            Console.WriteLine();
            return int.Parse(MyInput);

        }
    
    }
}
