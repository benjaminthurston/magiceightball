using System;

namespace eightball
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answers = 
            {
                "Yes",
                "No",
                "Ask the next guy!",
                "Signs point to yes",
                "Are you sure you want me to answer that?",
                "Think on that question, take a break and ask it again",
                "Go ask that other eight ball! I hear they are nicer.",
                "Are you flirting with me?",
                "I need a nap",
                "It is certain.",
                "It is decidedly so.",
                "Without a doubt.",
                "Yes – definitely.",
                "You may rely on it.",
                "As I see it, yes.",
                "Most likely.",
                "Outlook good.",
                "Reply hazy, try again.",
                "Not da mama",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don't count on it.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Very doubtful."



            };
            while (true)
            {
                Random rnd = new Random();
                int result = rnd.Next(0, 26);

                Console.WriteLine("The not so mighty Eight Ball awaits your question! Ask a question and hit the enter key for the answer!");

                string inp = Console.ReadLine();

                Console.WriteLine(answers[result]);


            }
        }
    }
}
