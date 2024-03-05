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

 int[,] numbers = new int[,] {
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
PrintResult(numbers);