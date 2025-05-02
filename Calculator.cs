public class Calculator
{
    public double Divide(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
            throw new DivideByZeroException("Cannot divide by zero.");
    }
}
