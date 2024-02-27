// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateArray(int size){
    int[] arr = new int[size];

    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

int GetSize () {
    bool b = false;
    int size = 0;
    while (!b){
        Console.WriteLine("Задайте размер массива:");
        size = int.Parse(Console.ReadLine()!);
        if (size > 0){
            b = true;
        }
    }
    return size;
}

void ReplaceArray (int[] array){
    int temp;
    for (int i = 0; i < array.Length/2; i++){
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    Console.WriteLine("Replace...");
}

int length = GetSize();
int[] ints = CreateArray(length);
Console.Write(string.Join(" ", ints) + "\n\n");
ReplaceArray(ints);
Console.Write(string.Join(" ", ints));