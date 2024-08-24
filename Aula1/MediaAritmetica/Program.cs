namespace MediaAritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> values =
            [
                GetConsoleNumber("Insira o primeiro valor:"),
                GetConsoleNumber("Insira o segundo valor:"),
                GetConsoleNumber("Insira o terceiro valor:"),
            ];

            double average = CalculateAverageArithmetic(values);
            Console.WriteLine($"Média Aritmética dos valores informados é '{average}'");
        }

        private static double CalculateAverageArithmetic(List<int> values)
        {
            double sum = values.Sum(i => i);
            double average = sum / values.Count;

            return average;
        }
        public static int GetConsoleNumber(string consoleMessage)
        {
            Console.Write(consoleMessage);
            int number = int.Parse(Console.ReadLine());

            return number;
        }
    }
}