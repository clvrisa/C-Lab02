using System;
namespace Exercise3
{
    public class Solution
    {
        public int Solution(int A, int B)
        {
            Console.WriteLine("Enter first number:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            B = Convert.ToInt32(Console.ReadLine());
            return A & B;
        }
    }
}
