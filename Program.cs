using System;
class SumOfEvenNumbers
{
    static void Main(string[] args)
    {
        int sum1 = 0, sum2 = 0;
        Console.Write("Enter From Number:");
        int FromNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter To Number:");
        int ToNumber = Convert.ToInt32(Console.ReadLine());
        if (FromNumber > ToNumber)
        {
            Console.WriteLine("Invalid From and To Numbers");
        }
        if (FromNumber < ToNumber)
        {
            for (int i = FromNumber; i <= ToNumber; i++)
            {
                if (i % 2 == 0)
                    sum1 += i;
            }
            Console.Write($"Sum of even numbers from {FromNumber} to {ToNumber} is : {sum1}");
        }
        if (FromNumber < ToNumber)
        {
            for (int i = FromNumber; i <= ToNumber; i++)
            {
                if (i % 2 == 1)
                    sum2 += i;
            }
            Console.Write($"Sum of Odd numbers from {FromNumber} to {ToNumber} is : {sum2}");
        }
    }
}

