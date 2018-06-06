using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining Score counter which will be updated on correct answers
            int Score = 0;
            //Beginning of Question 1/Question done differently than others just for testing
            Console.WriteLine(QuestionOne());
            String Answer = Console.ReadLine();
            if(Answer == "gray")
            {
                Score++;
            }
            //Questions 2-5 all invoked inside the if statement. 
            if(QuestionTwo() == "2")
            {
                Score++;
            }
            if(QuestionThree() == true)
            {
                Score++;
            }
            if(QuestionFour() == "23")
            {
                Score++;
            }
            if(QuestionFive() == 2)
            {
                Score++;
            }
            Results(Score);

        }
        //Where I define each question
        static string QuestionOne()
        {
            return "What is Collin's favorite Color?";
        }
        static string QuestionTwo()
        {
            Console.WriteLine("Which animal does Collin have a tattoo of?");
            Console.WriteLine("1. Giraffe");
            Console.WriteLine("2. Shark");
            Console.WriteLine("3. Unicorn");
            Console.WriteLine("4. Tiger");
            return Console.ReadLine();
        }
        static bool QuestionThree()
        {
            Console.WriteLine("True or False, Collin is left handed");
            if(Console.ReadLine() == "true")
            {
                return true;
            }
            return true;
        }
        static string QuestionFour()
        {
            Console.WriteLine("How old is Collin?");
            return Console.ReadLine();
        }
        static int QuestionFive()
        {
            Console.WriteLine("How many siblings does Collin have?");
            return Convert.ToInt32(Console.ReadLine());
        }
        //Lastly the method that handles the messaging of the score. It is called at the bottom of main
        static void Results(int score)
        {
            if (score > 3)
            {
                Console.WriteLine($"Congrats you passed with a score of {score}");
            }
            else
            {
                Console.WriteLine($"Sorry, but you failed with a score of {score}");
            }
            Console.ReadKey();
        }
    }
}
