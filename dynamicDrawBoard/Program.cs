using System;

namespace dynamicDrawBoard
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Let's make an array! You decide the size.");
            Console.Write("Number of columns: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of rows: ");
            int y = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < y; i++)
            {
                for (var j = 0; j < x; j++)
                {
                    Console.Write("x  ");
                }
                Console.WriteLine('\n');
            }
        }
    }
}
