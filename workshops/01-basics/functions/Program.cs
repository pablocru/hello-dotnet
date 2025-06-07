namespace functions;

class Program
{
    static void Main(string[] args)
    {
        int firstNumber = 10;
        int secondNumber = 20;
        int result = Add(firstNumber, secondNumber);

        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {result}");

        firstNumber = 7;
        secondNumber = 9;
        result = Add(firstNumber, secondNumber);

        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {result}");
    }

    static int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
}
