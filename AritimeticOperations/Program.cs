namespace AritimeticOperations;
class Program
{
    static void Main(string[] args)
    {
        int firstOperand = 15;
        int secondoperand = 3;

        int addResult = firstOperand + secondoperand;
        int subtractResult = firstOperand - secondoperand;
        int multiplyResult = firstOperand * secondoperand;
        int divisionResult = firstOperand / secondoperand;

        Console.WriteLine(firstOperand + "+" + secondoperand + "= " + addResult);
        Console.WriteLine(firstOperand + "-" + secondoperand + "= " + subtractResult);
        Console.WriteLine(firstOperand + "x" + secondoperand + "= " + multiplyResult);
        Console.WriteLine(firstOperand + "/" + secondoperand + "= " + divisionResult);
    }
}
