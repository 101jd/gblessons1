/* Дано нечетное число n, не превосходящее 15. 
Создайте двумерный массив из n×n элементов, 
заполнив его символами "." 
(каждый элемент массива является строкой из одного 
символа). Затем заполните символами "*" 
среднюю строку массива, средний столбец массива, 
главную диагональ и побочную диагональ. В результате 
"*" в массиве должны образовывать изображение звездочки.
 Выведите полученный массив на экран, 
разделяя элементы массива пробелами. */

/*
В кинотеатре n рядов по m мест в каждом 
(n и m не превосходят 20). 
В двумерном массиве хранится информация о проданных 
билетах, число 1 означает, что билет на данное место 
уже продан, число 0 означает, что место свободно. 
Поступил запрос на продажу k билетов на соседние места 
в одном ряду. Определите, можно ли выполнить такой запрос.
Sample Input:
3 4
0 1 0 1
1 0 0 1
1 1 1 1
2
Sample Output:
2
*/


int [,] CreateCinema (int rows = 10, int columns = 15){
    int[,] array = new int[input, input];
    for (int i = 0; i < input; i++){
        for (int j = 0; j < input; j++){
            array[i, j] = new Random().Next(0, 2);
        }
    }
    return array;
}

bool IsFree(int k, int[,] array){
    bool flag = true;
    for (int i = 0; i < input; i++){
        for (int j = 0; j < input; j++){
            if (array[j] == 0 && j + k < array.GetLength(1)){
                for (l = j; l < k+1; l++){
                    
                    if (array[i,l] == 1)
                        flag = false;
                }
                if (flag)
                    return true
            }
        }
    }
    return false;
}

int input;
do {
    input = int.Parse(Console.ReadLine());
} while  (n > 15 || n < 1);

string [,] CreateNew (){
    int[,] array = new int[input, input];
    for (int i = 0; i < input; i++){
        for (int j = 0; j < input; j++){
            array[i, j] = ".";
        }
    }
    return array;
}
void FillArray (string[,] array){
    for (int i = 0; i < GetLength(0); i++){
        for (int j = 0; j < GetLength(1); j++){
            if (i == GetLength(0) / 2 || i = j || j = GetLength(1) / 2)
                array[i, j] = "*";
            
        }
    }
}

int[,] CreateArray (int min, int max, int rows, int columns){
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max+1);
        }
    }

    return array;
}

void PrintArray (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

bool IsEvenIndex (int i, int j){
    if (i % 2 == 0 && j % 2 == 0)
        return true;
    return false;
}

int[,] MakeSquares(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if(IsEvenIndex(i, j))
                array[i,j] *= array[i,j];
        }
    }
    return array;
}

int Sum (int[,] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        sum += array[i,i];
    }
    return sum;
}

int[,] ints = CreateArray(1,9,3,3);
PrintArray(ints);
Console.WriteLine();
PrintArray(MakeSquares(ints));