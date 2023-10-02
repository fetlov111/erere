// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        int[,] matrix = new int[10, 10];
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                matrix[i - 1, j - 1] = i * j;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{matrix[i, j],2} ");
            }
            Console.WriteLine();
        }
    }
}