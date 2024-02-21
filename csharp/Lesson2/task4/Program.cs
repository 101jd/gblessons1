int[] arr = new int[100];
Random random = new Random();
int val;
int max = arr[0];


for (int i = 0; i < arr.Length; i++){
    val = random.Next(1, 100);
    arr[i] = val;
}


for (int i = 0; i < arr.Length; i++){
    Console.Write($"{arr[i]} ");
}

for (int i = 1; i < arr.Length; i++){
    if (arr[i] > max){
        max = arr[i];
    }
}
Console.Write($"\n\n{max}");