using System;

namespace _1
{
    class Program
    {
        public static int GetNODModul(int val1, int val2)
        {
            while ((val1 != 0) && (val2 != 0))
            {
                if (val1 > val2)
                    val1 %= val2;
                else
                    val2 %= val1;
            }
            return Math.Max(val1, val2);
        }
    }
}