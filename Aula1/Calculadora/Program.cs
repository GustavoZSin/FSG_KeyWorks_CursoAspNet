

using System.Runtime.InteropServices;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstNumber = GetConsoleNumber("Insira o primeiro número:");
            string op = GetConsoleString("Insira a operação:");
            float secondNumber = GetConsoleNumber("Insira o segundo número:");

            var result = 0f;
            Calculate(firstNumber, op, secondNumber, ref result);
            Console.WriteLine($"Resultado da operação '{firstNumber} {op} {secondNumber}' é '{result}'.");
        }

        private static string GetConsoleString(string consoleMessage)
        {
            Console.Write(consoleMessage);
            return Console.ReadLine();
        }
        private static float GetConsoleNumber(string consoleMessage)
        {
            Console.Write(consoleMessage);
            return float.Parse(Console.ReadLine());
        }

        private static void Calculate(float firstNumber, string op, float secondNumber, ref float result)
        {
            var operations = new Dictionary<string, Func<float, float, float>>
            {
                { "+", Sum },
                { "-", Subtract},
                { "*", Multiply},
                { "/", Divide }
            };

            result = operations[op](firstNumber, secondNumber);
        }

        private static float Sum(float v1, float v2) => v1 + v2;
        private static float Subtract(float v1, float v2) => v1 - v2;
        private static float Divide(float v1, float v2) => v1 / v2;
        private static float Multiply(float v1, float v2) => v1 * v2;
    }
}
