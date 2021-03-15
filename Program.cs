using System;

namespace CharMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries); //read the input

            string str1 = nums[0];
            string str2 = nums[1];

            int resultSum = CalcSumCharCodes(str1, str2);
            Console.WriteLine(resultSum);
        }

        private static int CalcSumCharCodes(string str1, string str2)
        {
            int totalSum = 0;

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    totalSum += ((int)(str1[i]) * (int)(str2[i]));
                }
            }
            else if (str1.Length < str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    totalSum += ((int)(str1[i]) * (int)(str2[i]));
                }

                for (int i = str1.Length ; i < str2.Length; i++)
                {
                    totalSum += (int)(str2[i]);
                }
            }
            else // if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    totalSum += (int)(str1[i] * (int)(str2[i]));
                }

                for (int i = str2.Length; i < str1.Length; i++)
                {
                    totalSum += (int)(str1[i]);
                }
            }

            return totalSum;            
        }
    }
}
