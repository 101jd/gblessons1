using static System.Console;
/*TASK1:
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет: 
"Позиция по рядам выходит за пределы массива"
или
"Позиция по колонкам выходит за пределы массива"

Позиции в массиве считать от единицы.
*/

/* int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int FindElementByPosition (int[,] array, int x, int y){
        return array[x-1, y-1];
}

bool ValidatePosition(int[,] array, int x, int y){
    if (x-1 > array.GetLength(0) || y-1 > array.GetLength(1))
        return false;
    
    return true;
}

void PrintResult(int[,] numbers, int x, int y){
    if(!ValidatePosition(numbers, x, y)){
        if (x-1 > numbers.GetLength(0)){
            WriteLine("Позиция по рядам выходит за пределы массива");
        }
        if (y-1 > numbers.GetLength(1)){
            WriteLine("Позиция по колонкам выходит за пределы массива");
        }
        
    } else
    WriteLine(FindElementByPosition(numbers, x, y));
        
}

PrintResult(numbers, 2, 2); */

/* TASK2:
Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

/* int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Write($"{array[i, j]}\t");
        }
        WriteLine();
    }
}

int[,] SwapFirstLastRows(int[,] array){
    int rowSize = array.GetLength(0);
    int [] temp = new int [rowSize];
    
    for (int j = 0; j < rowSize; j++){
        temp[j] = array[0, j];
    }
    for (int j = 0; j < rowSize; j++){
        array[0, j] = array[rowSize-1, j];
    }
    for (int j = 0; j < rowSize; j++){
        array[rowSize-1, j] = temp[j];
    }
    return array;
}
//
void SwapItems(int[,] array, int i){
    //i = 3;
     int columnSize = array.GetLength(1);
    int rowSize = array.GetLength(0); 
    
        int temp = array[i, columnSize-1];
        array[i, columnSize-1] = array[rowSize-1, columnSize-1];
        array[rowSize-1, columnSize-1] = temp;
    
}

PrintArray(numbers);
WriteLine();
void PrintResult(int[,] numbers){
    int [,] ints = SwapFirstLastRows(numbers);
    SwapItems(ints, ints.GetLength(0)-1);
    PrintArray(ints);
}

PrintResult(numbers);
 */

 /*TASK3:
 Задайте прямоугольный двумерный массив. 
 Напишите программу, которая будет находить 
 строку с наименьшей суммой элементов.
 */

 /* int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
}; */

/*  int[,] numbers = new int[,] {
    {1, 2, 3, 4},          //6
    {5, 6, 7, 8},          //2
    {9, 10, 11, 12}          //17
            //30
};

int[] SumRows(int[,] array){
    int [] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++){
        sum[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum[i] += array[i, j];
        }
    }
    return sum;
}

WriteLine(string.Join(" ", SumRows(numbers)));

int MinIndex(int[] array){
    
    int min = array[0];
    int index = 0;
    
    for(int i = 1; i < array.Length; i++){
        if (array[i] < min){
            min = array[i];
            index = i;
        }
    }

    return index;
}

void PrintResult(int[,] numbers){
    Console.Write(MinIndex(SumRows(numbers)));
}

//WriteLine(MinIndex(SumRows(numbers)));
PrintResult(numbers); */

// TASK 4: Задайте двумерный массив 
// из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен 
// наименьший элемент массива. Под удалением 
// понимается создание нового двумерного массива без 
// строки и столбца

int[,] numbers = new int[,] {
    {1, 2, 3, 6, 4, 5},
    {1, 1, 8, 6, 8, 3},
    {7, 2, 0, 2, 4, 5},
    {9, 10, 11, 4, 8, 7},
    {4, 5, 11, 10, 4, 8}
};

int[] FindMinIndexes(int[,] array){
    int min = array[0,0];
    int[] indexes = {0, 0};
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if(array[i,j] < min){
                min = array[i,j];
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    }
    return indexes;
}

int[,] DeleteRowColumn(int[,] array, int[] indexes){
    int[,] ints = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < ints.GetLength(0); i++){
        for (int j = 0; j < ints.GetLength(1); j++){
            if (i >= indexes[0] && j < indexes[1]){
                ints[i,j] = array[i+1,j];
            } else if (j >= indexes[1] && i < indexes[0]){
                ints[i,j] = array[i,j+1];
            } else if (i >= indexes[0] && j >= indexes[1]){
                ints[i,j] = array[i+1,j+1];
            }else {
                ints[i,j] = array[i, j];
            }
            
        }
    }

    return ints;
}

void PrintResult (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] result = DeleteRowColumn(numbers, FindMinIndexes(numbers));
PrintResult(numbers);
System.Console.WriteLine();
PrintResult(result);