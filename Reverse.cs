using System.Security.AccessControl;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text.Json;

namespace leet
{
    public class Reverse
    {
        public static int reverse(int n)
        {
            int result = 0;
            string resString = string.Empty;
            if (n > int.MaxValue || n <= int.MinValue)
                return 0;

            bool isNegative = n < 0;
            string tmp = Math.Abs(n).ToString();
            Stack<char> process = new Stack<char>();

            foreach (var i in tmp)
            {
                process.Push(i);
            }
            if (process.Peek() == 0)
                process.Pop();

            if (isNegative)
                resString += "-";


            int stackSize = process.Count;
            for (int i = 0; i < stackSize; i++)
                resString += process.Pop();

            int.TryParse(resString, out result);
            return result;
        }
    }
}