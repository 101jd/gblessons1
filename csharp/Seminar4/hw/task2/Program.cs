//  Задайте массив заполненный случайными трёхзначными числами.
//  Напишите программу, которая покажет количество
//  чётных чисел в массиве.

int[] CreateArray(int size){
    int[] arr = new int[size];
    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(100, 1000);
    }

    return arr;
}

int AmountOfEvens(int[] array){
    int amount = 0;
    foreach (int e in array){
        if (e % 2 == 0){
            amount++;
        }
    }
    return amount;
}

int[] ints = CreateArray(8);

Console.Write(string.Join(" ", ints));
Console.Write($"\n{AmountOfEvens(ints)}");