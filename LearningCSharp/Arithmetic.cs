using System;

public class Arithmetic { 
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
        return (++firstNumber);
}

    public int DecrementAnswer(int firstNumber)
{
        return (--firstNumber);
}

    public (int quotient, int remainder) Mod(int dividend, int divisor)
    {
        var quotient = dividend / divisor;
        var remainder = dividend % divisor;

        return (quotient, remainder);

    }

    //public string PerfectSquare(int firstNumber)
    //{
    //    var squared = Math.Sqrt(firstNumber);
    //    // theoretically I want to do what is below
    //    // var check = (squared == int);
    //if (check)
    //    {
    //        return ("yes " + firstNumber + " is a perfect square");
    //}
    //    else
    //    {
    //        return ("no " + firstNumber + " is not a perfect square");
    //}
    //}

}
