using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion.Array
{
    partial class Array
    {
        static void Main(string[] args)
        {
            Array array = new Array();
            /*
            // Problem 1: Has Unique Chars
            string str = "hel0";
            bool hasUniqueChars = array.UniqueCharInString(str);
            Console.WriteLine(str + "has unique chars? : " + array.UniqueCharInString(str));
            Console.WriteLine("   " + "has unique chars? : " + array.UniqueCharInString("   "));
            Console.WriteLine("l" + "has unique chars? : " + array.UniqueCharInString("l"));
            Console.WriteLine("ab" + "has unique chars? : " + array.UniqueCharInString("ab"));
            Console.WriteLine("abcde" + "has unique chars? : " + array.UniqueCharInString("abcde"));
            Console.WriteLine("abcede" + "has unique chars? : " + array.UniqueCharInString("abcede"));
            Console.WriteLine("Null" + "has unique chars? : " + array.UniqueCharInString(null));
            */

            // Problem 2: Reverse String
            Console.WriteLine("Hello" + " : " + array.ReverseString("Hello"));
            Console.WriteLine("Null" + " : " + array.ReverseString(null));
            Console.WriteLine("               " + " : " + array.ReverseString("               "));
            Console.WriteLine("This is a test. " + " : [" + array.ReverseString("This is a test. ")+ "]");
        }
    }
}
