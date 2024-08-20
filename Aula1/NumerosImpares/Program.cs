namespace NumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista completa
            /*for (int i = 0; i <= 100; i++)
            {
                    Console.Write($"{i} ");
            }*/

            //Números Pares
            /*for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.Write($"{i} ");
            }*/

            //Números Ímpares
            /*for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                    Console.Write($"{i} ");
            }*/

            //Números Ímpares Com Lista
            /*var oddNumbers = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                    oddNumbers.Add(i);
            }

            foreach (int i in oddNumbers)
            {
                Console.Write($"{i} ");
            }*/

            var numbers = new Dictionary<string, List<int>>();

            for (int i = 0; i <= 100; i++)
            {
                string grupo = i % 2 == 0 ? "Par" : "Ímpar";

                if (numbers.TryGetValue(grupo, out var list))
                    list.Add(i);
                else
                    numbers.Add(grupo, new List<int>() { i });
            }
        }
    }
}
