using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion.Array
{
    partial class Array
    {
        // Time Complexity = O(N/2) ; Space Complexity = O(N)
        public string ReverseString(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length == 1) return str;

            char[] strArray = str.ToCharArray(); // str.ToArray<char>();

            int start = 0;
            int end = strArray.Count<char>() - 1;

            while (start < end)
            {
                char temp = strArray[end];
                strArray[end--] = strArray[start];
                strArray[start++] = temp;
            }

            return new string(strArray);
        }
    }
}
