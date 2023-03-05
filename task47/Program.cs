// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int Read(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
double[,] FillMatrix(int m, int n)
{
    double[,] matrix = new double[m,n];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
        matrix[i,j] = Math.Round((Math.Round(rand.NextDouble(), 3)*10),2);
       } 
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
        System.Console.Write(matrix[i,j]+"\t");
       } 
       System.Console.WriteLine();
    }
}

int m = Read("введите количество строк");
int n = Read("введите количество столбцов");
double[,] mymatrix = FillMatrix(m,n);
PrintMatrix(mymatrix);
