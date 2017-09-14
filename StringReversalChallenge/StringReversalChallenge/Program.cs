using System;
using System.Linq;

namespace StringReversalChallenge
{
    class Program
    {
        //This is the method that is the entry point for the Program to execute.
        //It contains a console write line asking for a string that will be reversed and calls
        //the string reversal method passing the input of the user.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string that will be reversed:");
            StringReversal(Console.ReadLine());
        }

        //static void StringReversal(string entry)
        //{
        //    Console.WriteLine(new string(entry.ToCharArray().Reverse().ToArray()));
        //    Console.Read();
        //}

        //This is a the String Reversal method that handles the logic for reversing the string
        //that has been inputed by the user.
        static void StringReversal(string entry)
        {
            string output = "";
            for (int i = (entry.Length - 1); i> -1; i--)
                {
                    output += entry[i];
                }
            Console.WriteLine(output);
            Console.Read();
        }
    }
}