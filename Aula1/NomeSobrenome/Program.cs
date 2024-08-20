namespace NomeSobrenome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = GetConsoleData("Insira seu nome:");
            string sobrenome = GetConsoleData("Insira seu sobrenome:");

            Console.WriteLine($"Nome completo: {nome} {sobrenome}.");
        }

        public static string GetConsoleData(string consoleMessage)
        {
            Console.Write(consoleMessage);
            return Console.ReadLine();
        }
    }
}
