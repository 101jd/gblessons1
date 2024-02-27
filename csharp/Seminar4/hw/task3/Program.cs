// Заполните массив на N (вводится с консоли <= 8)
// случайных чисел от 0 до 9
// Сформируйте целое число, состоящее из цифр массива
// Старший разряд числа -- нулевой индекс

int GetSize (){
    bool b = false;
    int number = 0;
    while (!b){
        Console.WriteLine("Введите размер массива от 1 до 8");
        number = int.Parse(Console.ReadLine()!);
        if (number > 0 && number < 9){
            b = true;
        }
    }
    return number;
}

int[] CreateArray (int size){
    int [] arr = new int[size];
    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

long GetNumber (int[] array){
    long number = 0;
    int digit = 1;
    foreach (int e in array){
        digit *= 10;
    }
    foreach (int e in array){
        number += e*digit/10;
        digit /= 10;
    }
    return number;
}

int size = GetSize();
int[] ints = CreateArray(size);

Console.Write(string.Join(" ", ints) + "\n");
Console.Write(GetNumber(ints));

