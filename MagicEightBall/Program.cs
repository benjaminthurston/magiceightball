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
            var fileData = File.ReadAllText("Answer.json");
            var answers = JsonSerializer.Deserialize<List<Answers>>(fileData);
            while (true)
            {
                    Random rnd = new Random();
                    int result = rnd.Next(0, answers.Count-1);

                    Console.WriteLine("The not so mighty Eight Ball awaits your question! Ask a question and hit the enter key for the answer!");

                    string inp = Console.ReadLine();

                    Console.WriteLine(answers[result].Answer);


            }
        
        }
    }
}
