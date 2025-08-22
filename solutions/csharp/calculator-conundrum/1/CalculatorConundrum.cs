using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        int result;
        if (operand2 == 0 && operation == "/")
        {
            return "Division by zero is not allowed.";
        }
        switch (operation)
        {
            case "+":
                result = operand1 + operand2;
                break;
            case "*":
                result = operand1 * operand2;
                break;
            case "/":
                result = operand1 / operand2;
                break;
            case "":
                throw new ArgumentException("Empty operation.");
            case null:
                throw new ArgumentNullException("Operation cannot be null.");
            default:
                throw new ArgumentOutOfRangeException("Invalid operation.");
        }
        return $"{operand1} {operation} {operand2} = {result}";
    }
}
