using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._1
{
    public class AssignmentMethods
    {
        public static bool IsPalindrome(int num)
        {
            //if (num < 0) { return false; }
            int forwardNum = num;
            int reversedNum = 0;
            
            while(num>0)
            {
                reversedNum *= 10;
                reversedNum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"{forwardNum} backward: {reversedNum}\n\tPalindrome? {forwardNum==reversedNum}");
            return forwardNum==reversedNum;
        }
        public static int DigitSums(int num)
        {
            int inputNum = num;
            int sum = 0;
            if(num<0) { num = -num; }
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"The sum of the digits of the number {inputNum} is {sum}");
            return sum;

        }

        public static bool HasDuplicates(int[] nums)
        {
            Console.Write("In the array [");
            foreach(int num in nums)
            {
                Console.Write($"{num}, ");
            }
            (int left, int top) = Console.GetCursorPosition();
            Console.SetCursorPosition(left-2, top);
            Console.Write("], ");

            Dictionary<int,bool> dict = new Dictionary<int,bool>();
            foreach (int num in nums)
            {
                if(dict.ContainsKey(num))
                {
                    Console.WriteLine($"{num} is found more than once.");
                    return true;
                }
                else
                {
                    dict.Add(num, true);
                }
            }
            Console.WriteLine("there are no duplicates.");
            return false;
        }
    }
}
