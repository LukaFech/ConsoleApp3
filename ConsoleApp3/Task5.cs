using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Task5
    {
        string text = " ";
        int a = 0;
        int b = 0;
        public Task5()
        {
            Console.Write("Enter your problem: ");
            text = Console.ReadLine();
            char[] separators = { '+', '-' };
            string[] nums = text.Split(separators);
            a = int.Parse(nums[0]);
            b = int.Parse(nums[1]);
        }
        public void Get_Val()
        {
            if (text.Contains('+'))
            {
                Console.Write(a+b);
            }
            else 
            {
                Console.Write(a - b);
            }
        }
    }
}
