int[] arr = {1, 2, 3, 4, 5};
int[] res = new int [arr.Length/2];

for ( int i = 0; i < res.Length; i++){
    res[i] = arr[i] * arr[arr.Length - 1 - i];
    Console.Write(res[i] + " ");
}