

int[] CreateArray (int length, int min, int max){
    int[] arr = new int [length];
    
    for (int i = 0; i < length; i++){
        arr[i] = new Random().Next(min, max+1);
    }
    return arr;
}

void PrintArray (int[] arr){
    foreach (int e in arr){
        Console.Write($"{e}, ");
    }
}

bool isPrime (int number){
    double limit = Math.Sqrt(number);

    for (int i = 2; i <= limit; i++){
        if (number % i == 0){
            return false;
        }
        
    }
    return true;
}

int CountPrimes (int [] arr) {
    int count = 0;
    foreach (int e in arr){
        if(isPrime(e)){
            count++;
        }
    }
    return count;
}

Console.WriteLine("Input min");
int minimum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input max");
int maximum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input size");
int size = int.Parse(Console.ReadLine()!);

int[] ints = CreateArray(size, minimum, maximum);
Console.WriteLine(CountPrimes(ints));
/* PrintArray(ints);  */