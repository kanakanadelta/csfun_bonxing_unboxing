using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();
            list.Add(7);
            list.Add(28);
            list.Add(-1);
            list.Add(true);
            list.Add("chair");

            int sum = 0;
            for(int idx = 0; idx < list.Count; idx++)
            {
                if(list[idx] is int)
                {
                    sum+=(int)list[idx];
                }
            }

            Console.WriteLine(sum);    
        }
    }
}
