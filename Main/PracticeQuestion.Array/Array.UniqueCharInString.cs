using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion.Array
{
    partial class Array
    {
        // Time Complexity = O(N) ; Space Complexity = O(1)
        public bool UniqueCharInString( string str)
        {
            if (string.IsNullOrEmpty(str)) return false;

            // If ASCII, it can max have 256 unique chars and if length exceeds 256, this indicates that it has duplicate chars
            if (str.Length > 256) return false;

            bool[] charStatus = new bool[256]; 

            for(int i=0; i<str.Length; i++)
            {
                char val = str[i];
                if (charStatus[val]) return false;
                charStatus[val] = true;
            }

            return true;
        }
    }
}
