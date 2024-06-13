namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reversed string
            Console.Write("Please input the text: ");
            string str = Console.ReadLine();
            int length = str.Length - 1;

            for (int i = length; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
