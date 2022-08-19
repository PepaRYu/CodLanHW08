Console.WriteLine("Задайте количество строк матрицы M");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы M и строк матрицы N");
int RowsColums = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество столбцов матрицы N");
int columns = Convert.ToInt32(Console.ReadLine());



int [,] GetArray (int m, int n , int minRandom, int maxRandom ){
    int [,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j]  = new Random().Next(minRandom, maxRandom+ 1);
        }
        
    }
    return result;
}

void PrintArray(int [,] matrix){
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}


int [, ] MultiPlication(int [,] leftMatrix, int [, ] rightMatrix){
    int [, ] multiplication = new int [leftMatrix.GetLength(0), rightMatrix.GetLength(1)];
        for (int i = 0; i < leftMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < leftMatrix.GetLength(1); j++)
            {
                int currentElement = 0;
                for (int k = 0; k < rightMatrix.GetLength(1); k++)
                {
                    currentElement+= leftMatrix[i, k]*rightMatrix[k, j];
                }
                multiplication[i,j] = currentElement;
            }
        }
        return multiplication;
}


int [, ] MatrixM = GetArray(rows, RowsColums, 0, 10);
int [, ] MatrixN = GetArray(RowsColums, columns, 0, 10);

Console.WriteLine("Выводим первую матрицу на экран");
PrintArray(MatrixM);
Console.WriteLine("Выводим вторую матрицу на экран");
PrintArray(MatrixN);
Console.WriteLine("Выводим произведение матриц на экран");
PrintArray(MultiPlication(MatrixM, MatrixN));