namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int firstNumber = GetConsoleNumber("Insira o primeiro número:");
                string op = GetConsoleString("Insira a operação:");

                ValidateOperator(op);

                int secondNumber = GetConsoleNumber("Insira o segundo número:");

                //var result = 0f;
                var result = 0;
                Calculate(firstNumber, op, secondNumber, ref result);
                Console.WriteLine($"Resultado da operação '{firstNumber} {op} {secondNumber}' é '{result}'.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ValidateOperator(string op)
        {
            var operators = new List<string>() { "+", "-", "*", "/" };

            if (!operators.Contains(op))
                throw new Exception("Caractere informado não é um operador válido para cálculo.");
        }

        private static string GetConsoleString(string consoleMessage)
        {
            Console.Write(consoleMessage);

            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                throw new Exception("Informação inserida não pode ser nula.");

            return input;
        }
        private static int GetConsoleNumber(string consoleMessage)
        {
            string input;
            try
            {
                input = GetConsoleString(consoleMessage);
                int value = int.Parse(input);

                return value;
            }
            catch (FormatException ex)
            {
                throw new($"O valor informado não pode ser convertido para um valor numérico. Erro:{ex.Message}.");
            }
        }

        private static void Calculate(int firstNumber, string op, int secondNumber, ref int result)
        {
            var operations = new Dictionary<string, Func<int, int, int>>
            {
                { "+", Sum },
                { "-", Subtract},
                { "*", Multiply},
                { "/", Divide }
            };

            try
            {
                result = operations[op](firstNumber, secondNumber);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int Sum(int v1, int v2) => v1 + v2;
        private static int Subtract(int v1, int v2) => v1 - v2;
        private static int Divide(int v1, int v2) => v1 / v2;
        private static int Multiply(int v1, int v2) => v1 * v2;
    }
}