// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4 
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размер 1 матрицы:  ");
int[,] matrixA = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixA.GetLength(1); j++)
    {
        Console.Write("[{0}, {1}] = ", i, j);
        matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Введите размер 2 матрицы:  ");
int[,] matrixB = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < matrixB.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        Console.Write("[{0}, {1}] = ", i, j);
        matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Матрица А:");
Print(matrixA);
Console.WriteLine("Матрица В: ");
Print(matrixB);
int[,] C = Multiplication(matrixA, matrixB);
Console.WriteLine("Произведение двух матриц: ");
Print(C);



 static  int[,] Multiplication(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception ("Матрицы должны быть одиннаковые по размеру");
    int[,] r = new int[a.GetLength(0),b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1) ; j++)  
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i,j] += a[i,k] * b[k,j];
            }
        }
    }
    return r;
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0} ", a[i, j]);
        }
        Console.WriteLine();
    }
}