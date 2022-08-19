﻿Console.WriteLine("количество строк");
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

 int [, ] Progression(int [, ] array ){
    int [,] matrix = new int [ array.GetLength(0) , array.GetLength(1) ];
    for (int i = 0; i < array.GetLongLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            int key = array[i, j];
            for (int p = j - 1; p >= 0 && array[i, p] > key; p-- )
            {
                array[i, p + 1] = array[i, p];
                array[i, p  ] = key;
            }            
        }
    
    }
    return array;
 }

int [, ] matrix = GetArray(rows, columns, 0, 10);
PrintArray(matrix);
Console.WriteLine();
PrintArray(Progression(matrix));
