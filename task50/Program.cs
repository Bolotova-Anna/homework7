//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int Read(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
        matrix[i,j] = rand.Next(-3,9);
       } 
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
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
void GetNumber (int[,] matrix)
{
    System.Console.WriteLine("введите позицию строки");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("введите позицию столбца");
    int b = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(a == i && b ==j)
            {
                System.Console.WriteLine("искомое значение: "+ matrix[i,j]);
                return;
            }
        }
    }
    System.Console.WriteLine("такого элемента не существует");
}
int m = Read("введите количество строк");
int n = Read("введите количество столбцов");
int[,] mymatrix = FillMatrix(m,n);
PrintMatrix(mymatrix);
GetNumber(mymatrix);


