using System;

public class Assignment
{
    public int AddAssignAnswer(int firstNumber, int secondNumber)
    {
        return (firstNumber += secondNumber);
    }

    public int SubtractAssignAnswer(int firstNumber, int secondNumber)
    {
        return (firstNumber -= secondNumber);
    }
    public int MultiplyAssignAnswer(int firstNumber, int secondNumber)
    {
        return (firstNumber *= secondNumber);
    }

    public int DivideAssignAnswer(int firstNumber, int secondNumber)
    {
        return (firstNumber /= secondNumber);
    }

    public (int quotient, int remainder) ModAssign(int dividend, int divisor)
    {
        var remainder = dividend%divisor;
        dividend /= divisor;

        return (remainder, dividend);

    }

}
