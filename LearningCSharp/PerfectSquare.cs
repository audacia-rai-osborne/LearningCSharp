using System;

public class PerfectSquare
{
    public void perfectSquare(int num1)
    {
        int n;
        double squared;
        squared = Math.Sqrt(num1);
        n = (int)squared;
    if (n==squared)
        {
            Console.WriteLine("yes " + num1 + " is a perfect square");
    }
        else
        {
            Console.WriteLine("no " + num1 + " is not a perfect square");
    }
    }

}
