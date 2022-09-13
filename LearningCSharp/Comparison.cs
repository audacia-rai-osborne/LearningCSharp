using System;

public class Comparison
{
    public bool GreaterThan(int firstNumber, int secondNumber)
    {
        return firstNumber > secondNumber;
    }

    public bool LessThan(int firstNumber, int secondNumber)
    {
        return firstNumber < secondNumber;
    }
    public bool GreaterThanEqualTo(int firstNumber, int secondNumber)
    {
        return firstNumber >= secondNumber;
    }

    public bool LessThanEqualTo(int firstNumber, int secondNumber)
    {
        return firstNumber <= secondNumber;
    }

    public string Between(int firstNumber, int secondNumber, int thirdNumber)
    {
        if (firstNumber > secondNumber)
        {
            var b = firstNumber > thirdNumber && thirdNumber > secondNumber;
            return (thirdNumber + " being between " + firstNumber + " and " + secondNumber + " is " + b);
        }
        else
        {
            var c = thirdNumber < secondNumber && thirdNumber > firstNumber;
            return (thirdNumber + " being between " + firstNumber + " and " + secondNumber + " is " + c);
    }
    }

    public string PosAndNeg(int firstNumber)
    {
        if (firstNumber > 0)
        {
            return (firstNumber + " is postive");
        }
        else
        {
            return (firstNumber + " is negative");
    }
    }

    public bool AddAndCompare(int express1 , int express2)
    {
        return express1 > express2;
    }

}
