using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace eightball
{
    class Program
    {
        static void Main(string[] args)
        {
            //this reads from the Answer.json file 
            var fileData = File.ReadAllText("Answer.json");
            //Deserialize list for answers in file
            var answers = JsonSerializer.Deserialize<List<Answers>>(fileData);
            while (true)
            {
                //Makes random number to pull from list
                Random rnd = new Random();
                //pulls random number and goes to negative 1 so that later on I can add more answers
                int result = rnd.Next(0, answers.Count - 1);
                //Asks question
                Console.WriteLine("The not so mighty Eight Ball awaits your question! Ask a question and hit the enter key for the answer!\r\nType quit to stop program.");
                string inp = Console.ReadLine();
                //Exit program if you enter quit
                if (inp.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(answers[result].Answer);
                } 
            }
        }
    }
}
