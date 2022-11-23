using System;

namespace WHILE_EX_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 4;

            while (x < 3)
            {
                y = y + 2;
                x = x + 1;

                Console.WriteLine("X = "+ x + "Y = " + y); 

            }
        }
    }
}
