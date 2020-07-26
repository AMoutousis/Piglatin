using System;
using System.Runtime.CompilerServices;

namespace Capstone_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = "aeiou".ToCharArray();
            string lowerCaseInput;

            bool validLength = true;
            bool runAgain = true;


            Console.WriteLine("Hello! Welcome to this Pig Latin program!");

            while (runAgain)
            {
                while (validLength == true)
                {
                    Console.WriteLine("\nPlease type in a word: ");
                    string userInput = VerifyInput(Console.ReadLine());

                    MakeLowercase(userInput); 


                    lowerCaseInput = (MakeLowercase(userInput));


                    string[] words = lowerCaseInput.Split(' ');
                    
                    foreach (string word in words)
                    {
                        int firstVowel = word.IndexOfAny(vowels);


                        if (firstVowel == 0)
                        {
                            Console.Write($"{word}ay ");

                        }
                        else if (firstVowel == -1)
                        {
                            Console.Write($"{word} ");
                        }
                        else
                        {
                            string firstPart = word.Substring(firstVowel);
                            string secondPart = word.Substring(0, firstVowel);
                            Console.Write(firstPart + secondPart + "ay ");
                        }
                    }

                    Console.WriteLine("\n");


                    if (RunProgramAgain() == true)
                    {
                        runAgain = true;
                        validLength = true;
                    }
                    else
                    {
                        runAgain = false;
                        validLength = false;
                    }

                }
            }

        }

        public static string MakeLowercase(string userInput)
        {
            string lowerCaseInput;

            lowerCaseInput = userInput.ToLower();

            return lowerCaseInput;
        }
        
        public static string VerifyInput(string message)
        {
            while (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Please type in a word: ");
                message.Trim();
                message = Console.ReadLine();
            }


            return message;

        }
        public static bool RunProgramAgain()
        {
            bool validateAgain = true;
            bool repeatProgram = true;

            while (validateAgain == true)
            {
                Console.WriteLine("Would you like to run this program again? Enter y to run again or n to quit.");
                string playAgain = Console.ReadLine();

                if (playAgain.Length > 1 || playAgain.Length == 0)
                {
                    validateAgain = true;
                }
                else if (playAgain.ToLower() == "y")
                {
                    validateAgain = false;
                    repeatProgram = true;

                }
                else if (playAgain.ToLower() == "n")
                {
                    validateAgain = false;
                    repeatProgram = false;

                }
                else
                {
                    validateAgain = true;
                }
            }

            return repeatProgram;

        }
        
    }
}
