void FillArray (int[] arr, int min, int max){
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++){
        int value = rnd.Next(min, max);
        arr[i] = value;
    }
}
void PrintArray (int[] arr){
    foreach (int e in arr){
        Console.Write($"{e} ");
    }
}

int CalculateSum (int[] arr){
    int result = 0;
    foreach (int e in arr){
        result += e;
    }
    return result;
}

long CalculateProduct (int[] arr){
    long result = 1;
    foreach (int e in arr){
        result *= e;
    }
    return result;
}

int[] ints = new int[10];
int min = 1;
int max = 10;
FillArray(ints, min, max);
PrintArray(ints);
Console.WriteLine("\n" + CalculateSum(ints));
Console.WriteLine(CalculateProduct(ints));