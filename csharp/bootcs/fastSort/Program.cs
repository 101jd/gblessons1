
int[] quickSort(int[] collection, int left, int right)
  {
    int i = left;
    int j = right;

    int pivot = collection[Random.Shared.Next(left, right)];
    while (i <= j)
    {
      while (collection[i] < pivot) i++;
      while (collection[j] > pivot) j--;

      //         v
      // 7 8 5 3 4 1 2
      //i = 0
      //j = 6
      //[i] = 7 > 4 => j = 5; [i] = 8 > 4 => j = 4; [i] 
      //[j] = 2 < 4 => i = 1; [j] = 4 == 4 .......;

      if (i <= j)
      {
        int t = collection[i];
        collection[i] = collection[j];
        collection[j] = t;
        i++;
        j--;
      }
    }
    if (i < right) quickSort(collection, i, right);
    if (left < j) quickSort(collection, left, j);
    return collection;
  }

/*
int[] Concat (int[] a, int[] b, int[] c){

    int[] result = new int [a.Length + b.Length + c.Length];
    
    for (int i = 0; i < result.Length; i++){
	if (i < a.Length)
	   result[i] = a[i];
	else if (i >= a.Length && i < a.Length + b.Length)
	   result[i] = b[i - a.Length];
	else
	   result[i] = c[i - a.Length - b.Length];
    }
    return result;
}

int[] quickSort(int[] array){
    if (array.Length < 2){
        return array;
    }
    else{
        int pivot = array[0];
        int count = 0;
        foreach(int element in array){
            if (element < pivot)
                count++;
        }
        int[] less = new int[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] < pivot){
                less[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach(int element in array){
            if (element > pivot)
                count++;
        }
        int[] greater = new int[count];
        j = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > pivot){
                greater[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach(int element in array){
            if (element == pivot)
                count++;
        }
        int[] pivotArray = new int[count];
        for (int i = 0; i < count; i++){
            pivotArray[i] = pivot;
        }
        int[] result = Concat(quickSort(less), pivotArray, quickSort(greater));
        return result;
    }
}
*/

Console.Clear();
int[] array = {7, 4, 1, 3, 5, 2, 8, 6};
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Отсростированный массив: [{string.Join(", ", quickSort(array, 0, array.Length-1))}]");

/* int[] a = {1, 2, 3, 4};
int[] b = {5, 6, 7, 8};
int[] c = {9, 10, 11, 12};
Console.WriteLine(string.Join(", ", Concat(a, b, c))); */