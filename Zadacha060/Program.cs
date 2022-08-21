void PrintArray(int [, ] matrix){
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задаём размер квадртаной матриы");
int size = Convert.ToInt32(Console.ReadLine());

int [, ] matrix = new int[size, size];

for (int ik = 0; ik < size; ik++)
{
    for (int jk = 0; jk < size; jk++)
    {
        int i = ik + 1;
        int j = jk + 1;
        int switcher  = (j - i + size)/size;
        int Ic = Math.Abs(i - size/2 - 1) + (i - 1)/(size/2)*((size-1)%2);
        int Jc = Math.Abs(j - size/2 - 1) + (j - 1)/(size/2)*((size - 1)%2);
        int Ring = size/2 - (Math.Abs(Ic - Jc) + Ic + Jc)/2;
        int Xs = i - Ring + j - Ring - 1;
        int Coef = 4 * Ring * (size - Ring);
        matrix[ik, jk] = Coef + switcher * Xs + Math.Abs(switcher  - 1) * (4 * (size - 2 * Ring) - 2 - Xs);
    }
    
}
PrintArray(matrix);