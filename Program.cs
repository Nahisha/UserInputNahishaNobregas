using System;

namespace UserInputNahishaNobregas
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hey, how are you? This is Nahisha Nobregas!- type your answer below and hit enter";
            string userGreeting = "";

            if (greeting == "Hey, how are you? This is Nahisha Nobregas!- type your answer below and hit enter")
            {
                userGreeting = "I'm doing great, thank you!" +
                    "You typed: I'm doing great, thank you!";
            }

            userGreeting = Console.ReadLine();

           
     
           
        }
    }
}
