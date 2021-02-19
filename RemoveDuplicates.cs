using System.Security.AccessControl;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text.Json;

namespace leet
{
    public class RemoveDuplicate
    {
        public static int removeDuplicates(int[] num)
        {
            if(num.Length == 0)
                return 0;
            int i = 0;
            for (int j = 1; j < num.Length; j++)
            {
                if (num[j] != num[j])
                {
                    i++;
                    num[i] = num[j];
                }
            }
            return i+1;
        }
    }
}