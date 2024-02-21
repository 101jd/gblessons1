int n = 8;
int[] arr1 = new int [n];
Random rand = new Random();
int val;
for (int i = 0; i < arr1.Length; i++){
    val = rand.Next(1, 10);
    arr1[i] = val;
}

for (int i = 0; i < arr1.Length; i++){
    Console.Write($"{arr1[i]} ");
}

Console.Write("\n");

int[] arr2 = new int [n];
int j = 0;

while (j < arr2.Length){
    arr2[j] = j+1;
    Console.Write($"{arr2[j]} ");
    j++;
}