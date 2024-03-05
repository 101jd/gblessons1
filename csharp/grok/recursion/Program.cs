// task 1: Сумма эл-тов массива

int[] ints = {1, 3, 4, 99, 6, 8, 10};

int Sum (int[] array){
    // base
    if (array.Length == 1)
        return array[0];
    
    //recursion
    int[] remainder = new int[array.Length - 1];
    for (int i = 0; i < remainder.Length; i++){
        remainder[i] = array[i + 1];
    }
    return array[0] + Sum (remainder);
}



System.Console.WriteLine(Sum(ints));

// task 2: Подсчёт эл-тов массива
int CountIndexes (int[] array){
    int sum = 1;
    // base
    if (array.Length == 1)
        return 1;

    //recursion
    int[] remainder = new int[array.Length - 1];
    return sum + CountIndexes(remainder);
}

System.Console.WriteLine(CountIndexes(ints));

// task 3: Найти наибольшее число в массиве
int FindMax (int[] array){
    int pivot = array[0];
    // base
    if (array.Length == 1){
        return pivot;
    }
    
    int count = 0;
    for (int i = 1; i < array.Length; i++){
      if (array[i]  > pivot)
        count++;
    }

    if (count == 0)
        return pivot;
    
    //recursion
    
    int[] more = new int [count];
    pivot = array[0];
    int j = 0;
    for (int i = 1; i < array.Length; i++){
        if (array[i]  > pivot){
            more[j] = array[i];
            j++;
            //System.Console.WriteLine(more[j]);
        }
        //System.Console.WriteLine(array[i]);
    }

    return FindMax(more);
}

System.Console.WriteLine(FindMax(ints));

// task 4: Binary Search

int GuessNumber (int min, int max){ //доработать, не включает нижнюю границу
    int mid = (min + max) / 2;
    if (max - min == 1)
        return max;
    
    System.Console.WriteLine($"Число больше {mid}? y/n");
    string input = Console.ReadLine();
    if (input == "y"){
        return GuessNumber (mid, max);
    } else
        return GuessNumber(min, mid);
}

// task 4*: Бинарный поиск в массиве
bool FindElement (int[] array, int number){
    // base
    if (array.Length == 1)
        if (array[0] == number)
            return true;
            else return false;
    
    //recursion
    int[] left = new int [array.Length / 2];
    for (int i = 0; i < left.Length; i ++){
        left[i] = array[i];
    }
    int[] right = new int [array.Length - left.Length];
    for (int i = 0; i < right.Length; i++){
        right[i] = array[left.Length + i];
    }
    return FindElement(left, number) || FindElement(right, number);
}

System.Console.WriteLine(FindElement(ints, 123));
System.Console.WriteLine(FindElement(ints, 99));
//System.Console.WriteLine(GuessNumber(1, 100));
