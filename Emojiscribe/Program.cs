using System;

namespace Emojiscribe.Controller
{
    /// <summary>
    /// Main entry to tool.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name="args">Arguments.</param>
        public static void Main(string[] args)
        {
            String inputString = ReadUserInput("Enter text to emojiscribe:");

            Console.WriteLine(inputString);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(false);
        }

        /// <summary>
        /// Read console input, with a given prompt message.
        /// </summary>
        /// <param name="prompt">Message to display as a prompt.</param>
        /// <returns>Console input line.</returns>
        private static String ReadUserInput(String prompt)
        {
            Console.WriteLine(prompt);

            String userinput = Console.ReadLine();

            return userinput;
        }
    }
}
