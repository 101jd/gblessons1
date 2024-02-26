int[] ints = {5, -10, 34, 23, 2, 1};
int limit = ints.Length;

void SplitArray (int[] arr){
    int point = arr[0];
    int m = 0;
    int l = 0;
    foreach (int e in arr){
        if (e > point){
            m++;
        } else {
            l++;
        }
    }
    int[] less = new int[l-1];
    int[] more = new int[m];
    m = 0;
    l = 0;


    for (int i = 1; i < arr.Length; i++){
        
        if (arr[i] > point){
            more[m] = arr[i];
            m++;
        } else {
            less[l] = arr[i];
            l++;
        }
    }

Console.WriteLine(point);
    foreach (int e in less){
        Console.Write($"{e}, ");
    }
Console.WriteLine("");
    foreach (int e in more){
        Console.Write($"{e}, ");
    }
    
}

SplitArray(ints);

