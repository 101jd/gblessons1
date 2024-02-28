// void PrintMatrix (int[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
bool IsInteresting (int number){
    if (GetSumOfNumbers(number) % 2 == 0)
        return true;
    return false;
}

int GetSumOfNumbers (int number){
    int sum = 0;
    while(number > 0){
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int[] GetInteresting (int[,] matrix){
    int count = 0;
    foreach (int e in matrix){
        if (IsInteresting(e)){
            count++;
        }
    }
    int[] ints = new int[count];
    count = 0;
    // for (int i = 0; i < matrix.GetLength(0); i++){
    //     for (int j = 0; j < matrix.GetLength(1); j++){
    //         if(((matrix[i,j] / 10) + (matrix[i,j] % 10)) % 2 == 0){
    //             ints[count] = matrix[i,j];
    //             count++;
    //         }
    //     }
    // }
    foreach (int e in matrix){
        if (IsInteresting(e)){
            ints[count] = e;
            count++;
        }
    }
    return ints;
}



int [,] CreateMatrix (int rowSize, int columnSize){
    int [,] matrix = new int [rowSize, columnSize];
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(1, 1000);
        }
    }
    return matrix;
}

int[,] table = CreateMatrix(4, 4);
int[] ints = GetInteresting(table);
Console.Write(string.Join(" ", ints));