using System;

namespace leet
{
    /// <summary>
    /// 2021/2/9 LeetCode Sqrt
    /// https://leetcode.com/problems/sqrtx/
    /// 二元搜尋樹
    /// </summary>
    public class Sqrt
    {
        public static int sqrt(int x)
        {
            if (x < 2)
                return x;
            int right = x / 2 < 46340 ? x / 2 : 46340;  //46340為int32中最大平方根，若單純除2會導致計算平方數時溢位
            int left = 0;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                int midPower = middle * middle; //此處若搜尋空間>46340可能導致溢位
                if (midPower == x)
                    return (int)middle;
                else if (midPower > x)
                    right = middle - 1;
                else if (midPower < x)
                    left = middle + 1;
            }
            return right;
        }        
    }
}