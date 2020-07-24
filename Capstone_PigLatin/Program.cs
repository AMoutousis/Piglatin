using System;

namespace Capstone_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = "aeiou".ToCharArray();
            string lowerCaseInput;

            bool validLength = true;
            bool invalidLength = false;
            

            Console.WriteLine("Hello!");


            Console.WriteLine("Please type in a word: ");
            string userInput = Console.ReadLine();

            MakeLowercase(userInput); //convert input to lowercase for formatting and comparison

            Console.WriteLine($"The original input was: {userInput}");
            Console.WriteLine($"The lower case input is: {MakeLowercase(userInput)}");

            lowerCaseInput = (MakeLowercase(userInput));

            Console.WriteLine("Length " + lowerCaseInput.Length.ToString());
            int wordLength = int.Parse(lowerCaseInput.Length.ToString());



            //char[] splits = { ' ', ',', '.' };

            string[] words = lowerCaseInput.Split(' ');

            foreach (string word in words)
            {
                int firstVowel = word.IndexOfAny(vowels); //locate first vowel by comparing vowels char array to words


                if (firstVowel == 0)
                {
                    //string beginVowel = word.
                    Console.Write(word + "way ");

                }
                else
                {
                    string firstPart = word.Substring(firstVowel);
                    string secondPart = word.Substring(0, firstVowel);
                    Console.Write(firstPart + secondPart + "ay ");
                }
            }
            //FindVowel(lowerCaseInput);

            //FindVowel(MakeLowercase(lowerCaseInput));
            
        }
        
        //FindVowel is called to find the first vowel in the user entered string
        public static void FindVowel(string userWord)
        {
            char[] vowels = "aeiou".ToCharArray();

            Console.WriteLine("line 36");

            string word = userWord;
            int wordLength = int.Parse(word.Length.ToString(userWord));

            Console.WriteLine("In FindVowel");
            Console.WriteLine(wordLength);

            //for(int i = 0; i <= wordLength; )

        }
        
        /*public static string SeparateWords(string userInput)
        {
            string words = userInput.Split(' ');
        }
        */
        public static string MakeLowercase(string userInput)
        {
            string lowerCaseInput;

            lowerCaseInput = userInput.ToLower();

            return lowerCaseInput;
        }
    }
}
