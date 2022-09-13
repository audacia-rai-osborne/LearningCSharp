using System;

public class Fibonacci
{
int num = 0;
int i;

public (int, List<int>) FibonacciSequence(
    int fibNumber,
    List<int> fibList)
    {

            for (i = num; i <= 10; i++) {
                fibNumber = fibList[i] + fibList[i + 1];
                // fibList.push(fibNumber);
            }

            return fibNumber;
        }

    return (FibonacciSequence(0, [0, 1]));
}
