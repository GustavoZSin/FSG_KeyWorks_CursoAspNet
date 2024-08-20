namespace MediaCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalDistance = GetConsoleInt("Insira a distância total (Km):");
            double totalUsedFuel = GetConsoleDouble("Insira o total de combustível gasto (L):");

            double average = CalculateAverage(totalDistance, totalUsedFuel);
            Console.WriteLine($"Consumo médio foi de {Math.Round(average, 1)} Km/L");
        }

        private static double CalculateAverage(int totalDistance, double totalUsedFuel)
        {
            return totalDistance / totalUsedFuel;
        }

        public static int GetConsoleInt(string consoleMessage)
        {
            Console.Write(consoleMessage);
            return int.Parse(Console.ReadLine());
        }
        public static double GetConsoleDouble(string consoleMessage)
        {
            Console.Write(consoleMessage);
            return double.Parse(Console.ReadLine());
        }
    }
}