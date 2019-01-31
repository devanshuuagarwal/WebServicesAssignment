using ConsoleAppToConsumeWebServices.localhost;
using System;

namespace ConsoleAppToConsumeWebServices
{
    interface IGetInputFromConsole
    {
        string GetInput(int n);
    }

    public class GetInputFromConsole : IGetInputFromConsole
    {
        public string GetInput(int n)
        {
            string input = "";
            for (int i = 0; i < n; i++)
            {
                // Read input from console
                input += Console.ReadLine();

                //separate with comma
                if (i != n - 1)
                    input += ',';
            }
            return input;
        }
    }

    class ConsoleAppToConsumeWebServices
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many number's do you want to add");
            int n = Convert.ToInt32(Console.ReadLine());

            //Get Input From Console
            IGetInputFromConsole getInputFromConsole = new GetInputFromConsole();
            String input = getInputFromConsole.GetInput(n);

            // Making of an object of Web Service 
            WebServiceforAdd webServiceforAdd = new WebServiceforAdd();

            // Take the output as an object
            object getAddition = webServiceforAdd.Add(input);

            // Show the output to console
            Console.WriteLine(getAddition.ToString());
            Console.ReadKey();
        }
    }
}
