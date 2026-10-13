using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp3
{
    internal class Task_one
    {
        Random rnd = new Random();
        int[] arr1 = new int[5];
        double[,] arr2 = new double[3, 4];
        public Task_one()
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter num: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = rnd.NextDouble();
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write($"{arr2[i, j]} ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
        }
        public void Max()
        {
            double max = arr1[0];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (arr2[i,j] > max)
                    {
                        max = arr2[i,j];
                    }
                }
            }
            Console.WriteLine(max);
        }
        public void Min()
        {
            double min = arr1[0];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (arr2[i, j] < min)
                    {
                        min = arr2[i, j];
                    }
                }
            }
            Console.WriteLine(min);
        }
        public void Sum()
        {
            double sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    sum += arr2[i, j];
                }
            }
            Console.WriteLine(sum);
        }
        public void Product()
        {
            double sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum *= arr1[i];
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    sum *= arr2[i, j];
                }
            }
            Console.WriteLine(sum);
        }
        public void Sumofp()
        {
            double sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    sum += arr1[i];
                }
            }
            Console.WriteLine(sum);
        }
        public void Sumofnp()
        {
            double sum = 0;
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (arr2[i, j] % 2 != 0)
                    {
                        sum += arr2[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
