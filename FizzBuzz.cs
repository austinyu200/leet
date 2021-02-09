using System.Security.AccessControl;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text.Json;

namespace leet
{
    public class FizzBuzz
    {

        //3:Fizz
        //5:Buzz
        //3&5: FizzBuzz        
        public static IList<string> fizzBuzz(int n)
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }
            return result;
        }
    }
}