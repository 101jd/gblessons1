int n = 4;
int[] arr = new int [n];
Random rand = new Random();
int val;
for (int i = 0; i < arr.Length; i++){
    val = rand.Next(1, 10);
    arr[i] = val;
}

for (int i = 0; i < arr.Length; i++){
    Console.WriteLine(arr[i]);
}