using System;

public class Boolean
{

    public bool AndFunction(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
    {

        return (firstNumber > thirdNumber && secondNumber < fourthNumber);
    }

    public bool OrFunction(int firstnumber, int secondNumber, int thirdNumber, int fourthNumber)
    {
       return (firstnumber > thirdNumber || secondNumber < fourthNumber);
    }

    public bool NotFunction(int firstNumber, int secondNumber)
    {
        return firstNumber != secondNumber;
    }
}
