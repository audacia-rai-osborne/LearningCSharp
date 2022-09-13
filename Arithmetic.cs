using System;

public class Arithmetic { 
    public Arithmetic{
    public int AddAnswer(int firstNumber, int secondNumber)
{
    return (firstNumber + secondNumber);
}

    public int SubtractAnswer(int firstNumber, int secondNumber)
{
    return (firstNumber - secondNumber);
}

    public int MultiplyAnswer(int firstNumber, int secondNumber)
{
    return (firstNumber * secondNumber);
}

    public int ExponentAnswer(int firstNumber, int secondNumber)
{
        return (firstNumber ** secondNumber);
}

    public int ModulusAnswer(int firstNumber, int secondNumber)
{
        return (firstNumber % secondNumber);
}

    public int DivideAnswer(int firstNumber, int secondNumber)
{
        return (firstNumber / secondNumber);
}

    public int IncrementAnswer(int firstNumber)
{
        return (firstNumber++);
}

    public int DecrementAnswer(int firstNumber)
{
        return (firstNumber--);
}
}
}