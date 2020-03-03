using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UserInterface
    {

        public static string GetUserInputFor()
        {
            string input = Console.ReadLine();
            return input;
        }
        public static void PromptUser(string messageToUser)
        {
            Console.WriteLine(messageToUser);
        }
    }
}
