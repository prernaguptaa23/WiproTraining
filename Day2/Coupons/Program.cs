using System;

class CouponTracker
{
    static void Main()
    {
        // Input phase
        Console.Write("Enter number of coupons: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 100)
        {
            Console.WriteLine("Invalid number of coupons. Must be between 1 and 100.");
            return;
        }

        int[] coupons = new int[n];

        Console.WriteLine("Enter coupon values, separated by spaces:");
        string[] inputValues = Console.ReadLine().Split(' ');

        if (inputValues.Length != n)
        {
            Console.WriteLine("Number of entered coupon values does not match the count.");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            coupons[i] = int.Parse(inputValues[i]);
        }

        // Processing phase
        int totalValue = 0;
        int highestValue = coupons[0];
        int highestIndex = 0;

        int smallCount = 0;
        int mediumCount = 0;
        int largeCount = 0;

        for (int i = 0; i < n; i++)
        {
            int value = coupons[i];
            totalValue += value;

            // Find highest value and position
            if (value > highestValue)
            {
                highestValue = value;
                highestIndex = i;
            }

            // Category classification
            if (value <= 50)
                smallCount++;
            else if (value <= 100)
                mediumCount++;
            else
                largeCount++;
        }

        // Output phase
        Console.WriteLine("\n----- Daily Coupon Summary -----");
        Console.WriteLine("Total coupons redeemed  : " + n);
        Console.WriteLine("Total value collected   : " + totalValue);
        Console.WriteLine("Highest coupon redeemed : " + highestValue + " (coupon #" + (highestIndex + 1) + ")");

        Console.WriteLine("\nCategory breakdown");
        Console.WriteLine("Small  (≤50)   : " + smallCount);
        Console.WriteLine("Medium (51-100): " + mediumCount);
        Console.WriteLine("Large  (>100)  : " + largeCount);
    }
}