/*
    1822. Sign of the Product of an Array
    There is a function signFunc(x) that returns:

    [1]  if x is positive.
    [-1] if x is negative.
    [0]  if x is equal to 0.
    
    You are given an integer array nums. Let product be the product of all values in the array nums.

    Return signFunc(product).

 */

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { -1, -2, -3, -4, 3, 2, 1 };       // first provided Example
        Console.WriteLine(ArraySign(nums));

        int[] nums2 = { 1, 5, 0, 2, -3 };               // Second provided Example
        Console.WriteLine(ArraySign(nums2));

        int[] nums3 = { -1, 1, -1, 1, -1 };             // Third provided Example
        Console.WriteLine(ArraySign(nums3));

        int[] nums4 = { 41, 65, 14, 80, 20, 10, 55, 58, 24, 56, 28, 86, 96, 10, 3, 84, 4, 41, 13, 32, 42, 43, 83, 78, 82, 70, 15, -41 };
        Console.WriteLine(ArraySign(nums4));
    }

    public static int ArraySign(int[] nums)
    {
        int product = 1;                                // initialize product variable = 1

        foreach (int num in nums)                       // multiply values or return 0 if 0 is found
        {
            if (num == 0)
                return 0;

            else
                product *= num;
        }

        return SignFunc(product);                       // call SignFunc to determine the sign
    }

    public static int SignFunc(int x)
    {
        return (x > 0 ? 1 : -1);                        // equivalent to if(x>0) {return 1;} else {return -1;}
    }
}