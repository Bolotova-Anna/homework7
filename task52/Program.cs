// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
int m = Read("введите количество строк");
int n = Read("введите количество столбцов");
int[,] mymatrix = FillMatrix(m,n);
int[] array = new int[mymatrix.GetLength(1)];
PrintMatrix(mymatrix);
for (int j = 0; j < mymatrix.GetLength(1); j++)
{
    array[j] = 0;
    for (int i = 0; i < mymatrix.GetLength(0); i++)
    {
        array[j] = array[j] +mymatrix[i,j];
    }
    
    System.Console.Write("["+ string.Join(",",array[j]/mymatrix.GetLength(0))+"]");
}
      
    //  System.Console.WriteLine("["+ string.Join(",", array)+"]");

