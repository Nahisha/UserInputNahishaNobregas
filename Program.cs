using System;

namespace UserInputNahishaNobregas
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hey, how are you? This is Nahisha Nobregas!";
            string nextGreeting = "";

            if (greeting == "Hey, how are you? This is Nahisha Nobregas!")
            {
                nextGreeting = "I'm doing great, thank you!";
            }
            else if (greeting == "Hey there!")
            {
                nextGreeting = "How are you?"; 
            }
            else if (greeting == "Are you doing well?")
            {
                nextGreeting = "Yes I am, thank you for asking!";
            }

            Console.WriteLine(nextGreeting);
            
     
           
        }
    }
}
