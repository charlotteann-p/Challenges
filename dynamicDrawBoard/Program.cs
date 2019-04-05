using System;

namespace dynamicDrawBoard
{
    class Program
    {
        static void Main() 
        {
            Console.WriteLine("Let's make an array! You decide the size.");
            Console.Write("Number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pick a numbered space for your next move: ");
            int movelocation = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    string template = @" [{0}] ";
                    int boxnumber = counter++;
                    var movespace = String.Format(template, boxnumber);
                    if (movelocation == boxnumber)
                    {
                        movespace = " [x] ";
                    }
                    Console.Write(movespace);
                }
                Console.WriteLine('\n');
            }
        }
    }
}
