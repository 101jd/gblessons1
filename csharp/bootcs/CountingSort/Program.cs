// Counting Sort

using System.ComponentModel.DataAnnotations;

int[] ints = new int[100];
int[] other = new int[5];

void FillArray (int[] array, int min, int max){
    Random random = new Random();

    for (int i = 0; i < array.Length; i++){
        array[i] = random.Next(min, max);
    }
}

void ShowArray (int[] array){
    foreach (int e in array){
        System.Console.Write($"{e} ");
    }
}

void SortArray (int[] array){
    int[] counters = new int[10];

    for (int i = 0; i < array.Length; i++){
        counters[array[i]]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++){
        for(int j = 0; j < counters[i]; j++){
            array[index] = i;
            index++;
        }
    }
}

void CountingSortExtd(int[] array){
    int min = array.Min();
    int max = array.Max();
    int offset = 0 - min;

    int[] counters = new int [max + offset + 1];

    for (int i = 0; i < array.Length; i++){
        counters[array[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++){
        for(int j = 0; j < counters[i]; j++){
            array[index] = i - offset;
            index++;
        }
    }
}

FillArray(ints, 0, 10);
ShowArray(ints);
SortArray(ints);
System.Console.WriteLine();
ShowArray(ints);
System.Console.WriteLine();
FillArray(other, -10, 50);
ShowArray(other);
CountingSortExtd(other);
System.Console.WriteLine();
ShowArray(other);