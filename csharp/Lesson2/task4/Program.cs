int[] arr = new int[100];
Random random = new Random();
int val;
int max = arr[0];


for (int i = 0; i < arr.Length; i++){
    val = random.Next(1, 100);
    arr[i] = val;
}


foreach (int e in arr){
    Console.Write($"{e} ");
}

foreach (int e in arr){
    if (e > max){
        max = e;
    }
}
Console.Write($"\n\n{max}");