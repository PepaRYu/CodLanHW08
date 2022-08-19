Console.WriteLine("Задайте количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
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
void MinStringSumm(int [, ] array ){
    int minSumm = int.MaxValue;
    int stringCount = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumStrinigElm = 0;        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumStrinigElm += array[i, j];
        }
        if ( minSumm > sumStrinigElm )
        {
            minSumm = sumStrinigElm;
            stringCount = i;
        }
    }
    Console.WriteLine($"Номер строки с минимальной суммой элементов {stringCount}, сумма равна {minSumm} ");
}

int [, ] rectangleMatrix = GetArray(rows, columns, 0, 5);
PrintArray(rectangleMatrix);
Console.WriteLine();
MinStringSumm(rectangleMatrix);