void ZeroEven (int[] arr){
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] % 2 == 0){
            arr[i] = 0;
        }
    }
}

void PrintArray (int[] arr){
    foreach (int e in arr){
    Console.Write($"{e} ");
}
}

int[] ints = {2, 5, 4, 8, 15, 32, 33, 45};

ZeroEven(ints);
PrintArray(ints);
