﻿using System.Security.AccessControl;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text.Json;

namespace leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse :" + Reverse.reverse(-156468));
            Console.WriteLine("FizzBuzz :" + JsonSerializer.Serialize(FizzBuzz.fizzBuzz(15)));
        }


        
        public static void MoveZeroes(int[] nums)
        {
            LinkedList<int> linkedList = new LinkedList<int>(nums);
            var s = linkedList.Where(x => x == 1).FirstOrDefault();
        }
        
    }
}
