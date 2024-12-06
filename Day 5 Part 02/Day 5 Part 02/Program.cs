using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_5_Part_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Program 1
            //Console.Write("Enter a positive integer: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write(i);
            //    if (i < num) Console.Write(", ");
            //} 
            #endregion

            #region Program 2
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(num * i);

            //    if (i < 12) 
            //        Console.Write(", ");
            //} 
            #endregion

            #region Program 3
            //Console.Write("Enter a number: "); 
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= n; i += 2) 
            //{
            //    Console.Write(i);
            //    if (i != n && i != n - 1)
            //        Console.Write(", "); 
            //} 
            #endregion

            #region Program 4
            //Console.Write("Enter the first number: "); 
            //int baseNum = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //int exponent = int.Parse(Console.ReadLine()); 
            //int result = 1; 
            //for (int i = 0; i < exponent; i++) 
            //{
            //    result *= baseNum; 
            //}
            //Console.WriteLine($"{result}"); 
            #endregion

            #region Program 5
            //Console.Write("Enter a string: ");
            //string S = Console.ReadLine();
            //char[] charArray = S.ToCharArray();
            //Array.Reverse(charArray);
            //Console.WriteLine(new string(charArray)); 
            #endregion

            #region Program 6
            //Console.Write("Enter an integer to reverse: ");
            //int number = int.Parse(Console.ReadLine());
            //int reversed = 0;
            //while (number > 0)
            //{
            //    reversed = reversed * 10 + number % 10;
            //    number /= 10;
            //}
            //Console.WriteLine(reversed); 
            #endregion

            #region Program 7 
            Console.Write("Enter array elements separated by commas: ");
            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            var elementPositions = new Dictionary<int, List<int>>();
            int maxDistance = 0, firstIndex = -1, secondIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (!elementPositions.ContainsKey(array[i]))
                    elementPositions[array[i]] = new List<int>();
                elementPositions[array[i]].Add(i);
            }

            foreach (var positions in elementPositions.Values)
            {
                if (positions.Count > 1)
                {
                    int distance = positions.Last() - positions.First() - 1;
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        firstIndex = positions.First();
                        secondIndex = positions.Last();
                    }
                }
            }

            if (firstIndex != -1 && secondIndex != -1)
            {
                Console.WriteLine($"The longest distance is between the first {array[firstIndex]} and the {secondIndex + 1}th {array[secondIndex]}, with a distance of {maxDistance} cells.");
            }
            else
            {
                Console.WriteLine("No matching elements found.");
            }
            #endregion

            #region Program 8
            //Console.Write("Enter a sentence: ");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');
            //Array.Reverse(words);
            //foreach (string word in words) 
            //{
            //    Console.Write(word + " ");
            //} 
            #endregion

        }
    }
}
