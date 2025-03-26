using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    public class Solution
    {
        public static string reverseArray(string input)
        {
            StringBuilder s = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                s.Append(input[i]);
            }
            string result = s.ToString();
            return result;
        }
    }
}
