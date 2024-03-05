using static System.Console;

int [] CreateArray (int size){
    int [] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void SortBubble(int[] array){
    for (int i = 0; i < array.Length-1; i++){
        for (int j = 0; j < array.Length - 1; j++){
            if (array[j] > array[j+1]){
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
             } else 
                 continue;
            WriteLine(string.Join(" ", array));
        }
        
    }
}

int[] ints = {6, 5, 4, 3, 2, 1};
int[] arr = CreateArray(8);
WriteLine(string.Join(",", arr));
SortBubble(ints);