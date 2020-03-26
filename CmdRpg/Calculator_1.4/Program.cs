using System;

namespace Calculator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator 1.4\n");
            Console.WriteLine("Your options are:\n");
            Console.WriteLine("1. Addition\n");
            Console.WriteLine("2. Subtraction\n");
            Console.WriteLine("3. Multiplication\n");
            Console.WriteLine("4. Division\n");
            Console.WriteLine("5. Count\n");
            Console.WriteLine("6. Show Options\n");
            Console.WriteLine("7. Reset Calculator 1.4\n");
            Console.WriteLine("8. Off\n");
            int answer = 0;
            Startup(answer);
        }
        static void Startup(int answer)
        {
            int info = UserInput();
            switch (info)
            {
                case 1:
                    answer = Addition(answer);
                    Startup(answer);
                    break;

                case 2:
                    answer = Subtraction(answer);
                    Startup(answer);
                    break;

                case 3:
                    answer = Multiplication(answer);
                    Startup(answer);
                    break;

                case 4:
                    answer = Division(answer);
                    Startup(answer);
                    break;

                case 5:
                    answer = Count(answer);
                    Startup(answer);
                    break;

                case 6:
                    Showoptions();
                    Startup(answer);
                    break;

                case 7:
                    answer = Reset(answer);
                    Startup(answer);
                    break;

                case 8:
                    End();
                    break;

                default:
                    Console.WriteLine("Error\n");
                    Startup(answer);
                    break;
            }
        }
        static int Addition(int answer)
        {
            if (answer != 0)
            {
                Console.WriteLine("What would you like to add\n");
                Console.WriteLine(answer);
                int ans = answer;
                Console.WriteLine();
                string Ans2 = Console.ReadLine();
                int ans2 = Int32.Parse(Ans2);
                Console.WriteLine();
                answer = (ans + ans2);
                Console.WriteLine(answer);
            }
            
            if (answer == 0)
            {
                Console.WriteLine("What would you like to add to\n");
                Console.WriteLine(answer);
                string Ans = Console.ReadLine();
                int ans = Int32.Parse(Ans);
                string Ans2 = Console.ReadLine();
                int ans2 = Int32.Parse(Ans2);
                Console.WriteLine();
                answer = (ans + ans2);
                Console.WriteLine(answer);
            }
            return answer;
        }
        static int Count(int answer)
        {
            Console.WriteLine("type number to count to");
            string input = Console.ReadLine();
            int end = Int32.Parse(input);
            while (end > answer)
            {
                answer = answer + 1;
                Console.WriteLine(answer);
            }
            return answer;
        }
        static void End()
        {
            Console.WriteLine("Turning off...");
        }

        static int Subtraction(int answer)
        {
            if (answer != 0)
            {
                Console.WriteLine("What would you like to Subtract from\n");
                Console.WriteLine(answer);
                int ans = answer;
                Console.WriteLine();
                string Ans2 = Console.ReadLine();
                int ans2 = Int32.Parse(Ans2);
                Console.WriteLine();
                answer = (ans - ans2);
                Console.WriteLine(answer);
            }

            if (answer == 0)
            {
                Console.WriteLine("What would you like to Subtract from\n");
                Console.WriteLine(answer);
                string Ans = Console.ReadLine();
                int ans = Int32.Parse(Ans);
                string Ans2 = Console.ReadLine();
                int ans2 = Int32.Parse(Ans2);
                Console.WriteLine();
                answer = (ans - ans2);
                Console.WriteLine(answer);
            }
            return answer;
        }
        static int Division(int answer)
        {
            if (answer != 0)
            {
                Console.WriteLine("What would you like to Divide from\n");
                Console.WriteLine(answer);
                int ans = answer;
                Console.WriteLine();
                string Ans2 = Console.ReadLine();
                int ans2 = Int32.Parse(Ans2);
                Console.WriteLine();
                answer = (ans / ans2);
                Console.WriteLine(answer);
            }

            if (answer == 0)
            {
                Console.WriteLine("What numbers would you like to Divide\n");
                Console.WriteLine(answer);
                string Ans = Console.ReadLine();
                int ans = Int32.Parse(Ans);
                string Ans2 = Console.ReadLine();
                int ans2 = Int32.Parse(Ans2);
                Console.WriteLine();
                answer = (ans / ans2);
                Console.WriteLine(answer);
            }
            return answer;
        }
        static int Multiplication(int answer)
        {
            if (answer != 0)
            {
                Console.WriteLine("What number would you like to Multiply to\n");
                Console.WriteLine(answer);
                int ans = answer;
                Console.WriteLine();
                string Ans2 = Console.ReadLine();
                int ans2 = Int32.Parse(Ans2);
                Console.WriteLine();
                answer = (ans * ans2);
                Console.WriteLine(answer);
            }

            if (answer == 0)
            {
                Console.WriteLine("What numbers would you like to Multiply\n");
                Console.WriteLine(answer);
                string Ans = Console.ReadLine();
                int ans = Int32.Parse(Ans);
                string Ans2 = Console.ReadLine();
                int ans2 = Int32.Parse(Ans2);
                Console.WriteLine();
                answer = (ans * ans2);
                Console.WriteLine(answer);
            }
            return answer;
        }
        static void Showoptions()
        {
            Console.WriteLine("Your options are:\n");
            Console.WriteLine("1. Addition\n");
            Console.WriteLine("2. Subtraction\n");
            Console.WriteLine("3. Multiplication\n");
            Console.WriteLine("4. Division\n");
            Console.WriteLine("5. Count\n");
            Console.WriteLine("6. Show Options\n");
            Console.WriteLine("7. Reset Calculator 1.4\n");
            Console.WriteLine("8. Off\n");
        }
        static int UserInput()
        {
            int answer = 0;
            int info = 0;
            Console.WriteLine("Calculator 1.4");
            //NumericalCollector(answer);
            answer = info;
            string input = Console.ReadLine();
            try
            {
                info = Int32.Parse(input);
            }
            catch (Exception)
            {

            }
            return info;
        }
        static int Reset(int answer)
        {
            answer = 0;
            Console.WriteLine("Reset to zero");
            return answer;
        }
        //static int NumericalCollector(int answer)
        //{
        //    string input = Console.ReadLine();
        //    try
        //    {
        //        answer = Int32.Parse(input);
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    return answer;
        //}
    }
}   


