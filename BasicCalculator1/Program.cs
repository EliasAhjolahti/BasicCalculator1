using System;

class BasicCalculator
{
    static void Main()
    {
        Console.WriteLine("Basic Calculator");

        Console.Write("Syötä ensimmäinen nro: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Syötä + - / *: ");
        char op = Console.ReadLine()[0];

        Console.Write("Syötä toinen nro: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error");
                    return;
                }
                break;

            default:
                Console.WriteLine("Error operaattorissa");
                return;
        }

        Console.WriteLine($" {num1} {op} {num2} = {result}");
    }
}
