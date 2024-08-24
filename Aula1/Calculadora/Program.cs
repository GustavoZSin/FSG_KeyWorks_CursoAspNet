namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float firstNumber = GetConsoleNumber("Insira o primeiro número:");
                string op = GetConsoleString("Insira a operação:");

                ValidateOperator(op);

                float secondNumber = GetConsoleNumber("Insira o segundo número:");

                //var result = 0f;
                var result = 0f;
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
        private static float GetConsoleNumber(string consoleMessage)
        {
            string input;
            try
            {
                input = GetConsoleString(consoleMessage);
                float value = float.Parse(input);

                return value;
            }
            catch (FormatException ex)
            {
                throw new($"O valor informado não pode ser convertido para um valor numérico. Erro:{ex.Message}.");
            }
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
        private static float Divide(float v1, float v2)
        {
            if (v2 == 0)
                throw new DivideByZeroException("Tentativa de divisão por zero.");

            return v1 / v2;
        }
        private static float Multiply(float v1, float v2) => v1 * v2;
    }
}