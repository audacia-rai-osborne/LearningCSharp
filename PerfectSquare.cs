using System;

public class PerfectSquare
{
    public void perfectSquare(int num1)
    {
    var squared = Math.sqrt(num1)
    var check = Number.isInteger(squared)
    if (check)
        {
            Console.WriteLine("yes " + num1 + " is a perfect square");
    }
        else
        {
            Console.WriteLine("no " + num1 + " is not a perfect square");
    }
    }

}
