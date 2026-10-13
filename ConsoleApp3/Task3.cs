using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Task3
    {
        //char[] separators = { '+', '-' };
        //string[] nums = text.Split(separators);
        int counter = 0;
        string text = " ";
        char[] letters = new char[52] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public Task3() {}
        public void Start()
        {
            string newS = "";
            Console.WriteLine("Write your sentence");
            text = Console.ReadLine();
            text.ToLower();
            Console.WriteLine("Write num");
            counter = int.Parse(Console.ReadLine());
            char[] separators = { '.', ' ', ',' };
            string[] words = text.Split(separators);
            char[,] wordsc;
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("newS1");
                //
                string temp1;
                char temp = ' ';
                temp1 = words[i];
                string temp2 = " ";
                for (int j = 0; j < temp1.Length; j++)
                {
                    Console.WriteLine("newS2");
                    temp = temp1[j];
                    int alcount = 0;
                    for (int h = 0; h < letters.Length/2; h++)
                    {
                        if (temp == letters[h])
                        {
                            temp = letters[h + counter];
                            temp2 += temp;
                        }
                    }
                }
                newS += temp2;
            }
            Console.WriteLine(newS);
            
        }
    }
}
