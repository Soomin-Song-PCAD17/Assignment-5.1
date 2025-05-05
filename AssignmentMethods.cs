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
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"The sum of the digits of the number {inputNum} is {sum}");
            return sum;

        }
    }
}
