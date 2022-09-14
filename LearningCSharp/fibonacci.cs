using System;

public class Fibonacci
{
    int num = 0;
    int i;

    public List<int> FibonacciSequence(
        List<int> fibList)
    {
        for (i = num; i <= 9; i++)
        {
            var fibNumber = fibList[i] + fibList[i + 1];
            fibList.Add(fibNumber);
            Console.WriteLine(fibList[i]);
        }

        return fibList;
    }
}
