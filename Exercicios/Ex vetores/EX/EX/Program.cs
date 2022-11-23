using System;

namespace EX
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 0;

            while(x < 60)
            {
               
                
                x = x * 2;
               
                y = y + 10;
                Console.WriteLine(y);
            }
        }
    }
}
