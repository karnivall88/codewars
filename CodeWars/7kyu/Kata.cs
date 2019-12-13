using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._7kyu
{

    class Kata
    {
        public static long rowSumOddNumbers(long n)
        {
            return n*n*n;
        }

        public static int WordsToMarks(string str)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int result = 0;

            for(int i = 0;i<str.Length;i++)
            {
                result += alphabet.IndexOf(str[i])+1;
            }
            return result;
            
        }
    }
}
