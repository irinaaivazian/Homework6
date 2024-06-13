namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}    ");
                    Console.WriteLine();
                }
            }


        }
    }
}
