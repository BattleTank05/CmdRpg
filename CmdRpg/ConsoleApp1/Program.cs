using System;

namespace Trivia1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInstructions();
        }
        static bool QuestionsAndAnswers(string QuestionText, string[] PossibleAnswers, int TrueAnswer)
        {
            int answer = 0;
            Console.WriteLine(QuestionText);
            for (int i = 0; i < PossibleAnswers.Length; i++)
            {
                Console.WriteLine(PossibleAnswers[i] + "\n");
            }
            string info = Console.ReadLine();
            try
            {
                answer = Int32.Parse(info);
            }
            catch
            {
                Console.WriteLine("please pick from the given answers");
                Question1();
            }
            return answer;
        }
        static void ShowInstructions()
        {
            Console.WriteLine("Welcome to Trivia 1.0\n");
            Console.WriteLine("In this game you will be asked various questions.\n");
            Console.WriteLine("You will be required to type in whichever given answer you think is correct.\n");
            Console.WriteLine("If your answer is incorrect, you lose and will have to restart the game.\n");
            Console.WriteLine("one of the answers provided is correct... choose wisely!\n");
            Console.WriteLine("When you answer all questions correctly you will win.\n");
            Console.WriteLine("Your game begins now.\n");
            Question1();
        }
        static void Question1()
        {
            //var Ans1 = Console.ReadLine();
            //if (Ans1 != "612938563093983000 in.")
            //{
            //    Console.WriteLine("\nWow you are TERRIBLE at this game! you did not even get past Question 1!!");
            //    Console.WriteLine("would you like to go again?");
            //    var restart = Console.ReadLine();
            //    if (restart == "yes")
            //    {
            //        Console.WriteLine("Still got some fight in you eh? we'll put that to an end...");
            //        Question1();
            //    }
            //    else
            //        Console.WriteLine("\nShutting down...");
            //}
            //if (Ans1 == "612938563093983000 in.")
            //{
            //    Console.WriteLine("\nWell i'll be... you completed Question 1!\n");
            //    Question2();
            //}


            string text = "How deep is the Grand Canyon?";
            string[] pAnswers = { "1 12345 ft.", "2 120 mi.", "3 612938563093983000 in." };
            int tAnswer = 3;
            bool answer = QuestionsAndAnswers(text, pAnswers, tAnswer);
            if (answer)
            {
                Console.WriteLine("yay");
                Question2();
            }


        }
        static void Question2()
        {
            //Console.WriteLine("2\n");
            //Console.WriteLine("How much wood could a Woodchuck chuck if a Woodchuck could chuck wood?\n");
            //Console.WriteLine("i don't know\n");
            //Console.WriteLine("7007 pieces\n");
            //Console.WriteLine("777 pieces\n");
            //Console.WriteLine("786.77 pieces\n\n");
            //var Ans2 = Console.ReadLine();
            //if (Ans2 != "777 pieces")
            //{
            //    Console.WriteLine("\nanother one bites the dust...\n");
            //    Console.WriteLine("would you like to go again?\n");
            //    var restart = Console.ReadLine();
            //    if (restart == "yes")
            //    {
            //        Console.WriteLine("Still got some fight in you eh? we'll put that to an end...\n");
            //        Question1();
            //    }
            //    else
            //        Console.WriteLine("Shutting down...");
            //}
            //if (Ans2 == "777 pieces")
            //{
            //    Console.WriteLine("you have completed Question 2!\n");
            //    Question3();
            //}
        }
        static void Question3()
        {
            Console.WriteLine("3\n");
            Console.WriteLine("How many Crusades were there?\n");
            Console.WriteLine("3\n");
            Console.WriteLine("5\n");
            Console.WriteLine("7\n");
            Console.WriteLine("9\n");
            Console.WriteLine("11\n\n");
            var Ans3 = Console.ReadLine();
            if (Ans3 != "11")
            {
                Console.WriteLine("\nQuestion 3... not bad but still, losing is losing.\n");
                Console.WriteLine("would you like to go again?\n");
                var restart = Console.ReadLine();
                if (restart == "yes")
                {
                    Console.WriteLine("\nStill got some fight in you eh? we'll put that to an end...\n");
                    Question1();
                }
            }
            if (Ans3 == "11")
            {
                Console.WriteLine("If u think i'm dun with u, then ur a fool!");
                Question4();
            }
            else
                Console.WriteLine("Shutting down...");
        }
        static void Question4()
        {
            Console.WriteLine("\n4\n");
            Console.WriteLine("\nWhat was the answer to Question 1?\n");
            Console.WriteLine("612938563093983000 in.\n");
            Console.WriteLine("612938563893983000 in.\n");
            Console.WriteLine("612985123093983000 in.\n");
            Console.WriteLine("612938563093983090 in.\n");
            Console.WriteLine("612938563093763000 in.\n");
            Console.WriteLine("612938563493983000 in.\n"); 
            var Ans4 = Console.ReadLine();
            if (Ans4 != "612938563093983000 in.")
            {
                Console.WriteLine("\nFired! Question 4!\n");
                Console.WriteLine("would you like to go again?\n");
                var restart = Console.ReadLine();
                if (restart == "yes")
                {
                    Console.WriteLine("\nStill got some fight in you eh? we'll put that to an end...\n");
                    Question1();
                }
                else
                    Console.WriteLine("Shutting down...");
            }
            if (Ans4 == "612938563093983000 in.")
            {
                Console.WriteLine("\nNice work! you have completed Question 4! i seriously thought that would stump you...\n");
                Question5();
            }
        }
    static void Question5()
        {
            Console.WriteLine("\n5\n");
            Console.WriteLine("When life gives you pickles, lemons, and bad days, you would\n\n");
            Console.WriteLine("pickle the pickles, mince the lemons, and yell at the bad day to get better.\n");
            Console.WriteLine("eat the pickles, smile at the lemons, and say 'Go away, bad day!'\n");
            Console.WriteLine("chop the pickles and put them on a sandwhich covered in lemon rinds and seasoned with bad days.\n");
            Console.WriteLine("eat the pickles, the lemons, and the bad day so you can fart it all out later.\n");
            Console.WriteLine("pickle the pickles, lemons, and bad day.\n");
            Console.WriteLine("eat the pickles, make lemonade, and act as if the bad day just simply was not there.\n");
            Console.WriteLine("blow it away like all the other days.\n");
            var Ans5 = Console.ReadLine();
            if (Ans5 != "eat the pickles, make lemonade, and act as if the bad day just simply was not there.")
            {
                Console.WriteLine("\nFired! Question 4!\n");
                Console.WriteLine("would you like to go again?\n");
                var restart = Console.ReadLine();
                if (restart == "yes")
                {
                    Console.WriteLine("\nStill got some fight in you eh? we'll put that to an end...\n");
                    Question1();
                }
                else
                    Console.WriteLine("Shutting down...");
            }
            if (Ans5 == "eat the pickles, make lemonade, and act as if the bad day just simply was not there.")
            {
                Console.WriteLine("\nDang... i mean Nice, Nice you did it! you were not supposed to but ok");
            }
        }
    }
}
