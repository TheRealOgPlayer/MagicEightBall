/*
Made By therealogplayer
Date Made: 09/01/23
*/

using System;

namespace FinalBuildPlease
{
    class Program
    {
        static void SpinTheBall(string theQuestion)
        {

            Console.Clear();
            Console.Beep();

            //The Responses
            string[] Responses = { "It is certain", "It is decidedly so", "Without a doubt", "Yes definitely", "You may rely on it",
                "As I see it, yes", "Most likely", "Outlook good", "Yes", "Signs point to yes", "Reply hazy, try again", "Ask again later",
                "Better not tell you now", "Cannot predict now", "Concentrate and ask again", "Don't count on it", "My reply is no", "My sources say no",
                "Outlook not so good", "Very doubtful"};

            Random rnd = new Random();
            int randomNumber = rnd.Next(Responses.Length);

            Console.WriteLine("Your Question Was: {0}\nMy Response Is: {1}", theQuestion, Responses[randomNumber] + "\nIf You Would Like To Spin Again Press Enter...\nIf You Want To Quit Press E Then Enter...");


            //Respin Logic
            string nextKey = Console.ReadLine().ToUpper();
            if (nextKey == "E")
            {
                Environment.Exit(1);
            }
            GetTheQuestion();
        }

        static void GetTheQuestion()
        {
            Console.Clear();

            //Get the question from the user
            Console.WriteLine("Ask Me A Question?\n");
            string Question = Console.ReadLine();


            //Variables The Script Use
            string[] IlligalChar = { "(", ")", ";", "'", "+", "-", "*", "\n", "/", "||", "{", "}", "[", "]" };

            //Checks To Make Sure Word Provided Is Valid
            for (int i = 0; i < IlligalChar.Length; i++)
            {
                if (Question.Contains(IlligalChar[i]) == true)
                {
                    Console.WriteLine("{0} Contains Illeagl Character(s)" + "\nFirst Illegal Character Found: {1}", Question, IlligalChar[i] + "\nPress Enter To Re-ask Your Question...");
                    Console.ReadLine();
                    GetTheQuestion();
                }
            }

            SpinTheBall(Question);
        }

        static void Main(string[] args)
        {
            GetTheQuestion();
        }
    }
}
