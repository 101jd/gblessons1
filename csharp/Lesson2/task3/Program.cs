int n = 10;
int[] arr = new int[n];
Random rand = new Random();
int val;

for (int i = 0; i < arr.Length; i++){
    val = rand.Next(1, 10);
    arr[i] = val;
}

for (int i = 0; i < arr.Length; i++){
    if (arr[i] % 2 == 0){
        Console.Write($"{arr[i]} ");
    }
}