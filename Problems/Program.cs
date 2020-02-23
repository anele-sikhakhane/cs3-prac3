using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            static string Prefix(string input)
            {
            int words = 0;
            string wordx = "";
            string words1 = "";
            string inputx = input;
            int len = input.Length;
            string lenx = len.ToString();

            //Trim whitespace from beginning and end of string
            input = input.Trim();

            //Necessary because foreach will einputecute once with empty string returning 1
           if (input == "")
           {
                Console.WriteLine("0,0:");
                return "0,0:";
           }

            
           while (input.Contains("  "))
               input = input.Replace("  ", " ");

            while (input.Contains("."))
                input = input.Replace(".","");
                       
            while (input.Contains("?"))
                input = input.Replace("?","");


           foreach (string y in input.Split(' '))
               words++;
            
            wordx = words.ToString();
            Console.WriteLine(input);
            words1 = (lenx + "," + wordx + ":" + inputx);
            Console.WriteLine(words1);

            return words1;
                
             

            }

        // Prefix("   anele   ");
            Prefix("Hello");
            Prefix("");
            Prefix("what ... did you say?? ");

            
        }

    }
}
