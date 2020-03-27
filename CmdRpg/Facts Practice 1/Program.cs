using System;

namespace Facts_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program will count to 100 by increments of whatever number you type in\n");
            Loop();
        }
        static int CountParameter()
        {
            int end = 0;
            string input = Console.ReadLine();
            try
            {
                end = Int32.Parse(input);
            }
            catch
            {
                Console.WriteLine("Error");
                CountParameter();
            }
            if (end > 100)
            {
                Console.WriteLine("Number must be lower than 100\n");
                Loop();
            }
            return end;
        }
        static int Count(int end)
        {
            int count = 0;
            Console.WriteLine("\n");
            while (count < 100)
            {
                Console.WriteLine(count);
                count = end + count;
            }
            Console.WriteLine(count);
            return count;
        }
        static void Loop()
        {
            int end = CountParameter();
            while (end < 100)
            {
                end = Count(end);
            }
            if (end >= 100)
            {
                Console.WriteLine("\nthis program will count to 100 by increments of whatever number you type in\n");
                Loop();
            }
        }
    }
}
