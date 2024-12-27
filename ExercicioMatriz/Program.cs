namespace ExercicioMatriz;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número de linhas: ");
        int m = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o número de colunas: ");
        int n = int.Parse(Console.ReadLine());
        
        int[,] matriz = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            Console.Write($"Digite os valores da linha {i + 1}: ");
            string [] linha = Console.ReadLine().Split(" ");
            
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(linha[j]);
            }
        }
        Console.WriteLine("----------------------------------------");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matriz[i, j]}    ");
            }
            
            Console.WriteLine();
        }
        Console.WriteLine("----------------------------------------");
        Console.Write("Digite um valor que existe na matriz: ");
        int x = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] == x)
                {
                    Console.WriteLine($"Position {i},{j}: {matriz[i, j]}");
                    if (j > 0) Console.WriteLine($"Left: {matriz[i, j-1]}");
                    if (j < n - 1) Console.WriteLine($"Right: {matriz[i, j+1]}");
                    if (i > 0) Console.WriteLine($"Up: {matriz[i-1, j]}");
                    if (i< m -1) Console.WriteLine($"Down: {matriz[i+1, j]}");
                    
                }
            }
        }
    }
}