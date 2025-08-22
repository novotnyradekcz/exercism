using System;

public class CalculationException : Exception
{
    public CalculationException(int operand1, int operand2, string message, Exception inner)
    {
        this.Operand1 = operand1;
        this.Operand2 = operand2;
    }

    public int Operand1 { get; }
    public int Operand2 { get; }
}

public class CalculatorTestHarness
{
    private Calculator calculator;

    public CalculatorTestHarness(Calculator calculator)
    {
        this.calculator = calculator;
    }

    public string TestMultiplication(int x, int y)
    {
        if (x < 0 && y < 0)
        {
            try
            {
                calculator.Multiply(x, y);
            }
            catch (Exception e)
            {
                return "Multiply failed for negative operands. " + e.Message;
            }
        }
        else
        {
            try
            {
                calculator.Multiply(x, y);
            }
            catch (Exception e)
            {
                return "Multiply failed for mixed or positive operands. " + e.Message;
            }
        }
        return "Multiply succeeded";
    }

    public void Multiply(int x, int y)
    {
        try
        {
            calculator.Multiply(x, y);
        }
        catch (Exception e)
        {
            throw new CalculationException(x, y, e.Message, e);
        }
    }
}


// Please do not modify the code below.
// If there is an overflow in the multiplication operation
// then a System.OverflowException is thrown.
public class Calculator
{
    public int Multiply(int x, int y)
    {
        checked
        {
            return x * y;
        }
    }
}
