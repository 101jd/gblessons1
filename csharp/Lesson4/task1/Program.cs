void PrintMatrix (int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}




int [,] CreateMatrix (int rowSize, int columnSize){
    int [,] matrix = new int [rowSize, columnSize];
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(1, 11);
        }
    }
    return matrix;
}

int[,] table = CreateMatrix(8, 4);
PrintMatrix(table);