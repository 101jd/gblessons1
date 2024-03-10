const int THREAD_NUMBERS = 4;
const int SIZE = 100;

object locker = new object();

int[] ints = new int [SIZE];

void PrepareParallelCountings(int[] array){
    int min = array.Min();
    int max = array.Max();
    int offset = 0 - min;

    int[] counters = new int [max + offset + 1];

    int eachThreadCalc = SIZE / THREAD_NUMBERS;
    var threads = new List<Thread>();

    for (int i = 0; i < THREAD_NUMBERS; i++){
        int startPos = i * eachThreadCalc;
        int endPos = (i + 1) * eachThreadCalc;
        if (i == THREAD_NUMBERS - 1) endPos = SIZE;
        threads.Add(new Thread(() => CountingSortParallel(array, counters, offset, startPos, endPos)));
        threads[i].Start();
    }

    foreach (var t in threads){
        t.Join();
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++){
        for(int j = 0; j < counters[i]; j++){
            array[index] = i - offset;
            index++;
        }
    }
}

void CountingSortParallel (int[] array, int[] counters, int offset, int startPos, int endPos){
    for (int i = startPos; i < endPos; i++){
        lock (locker){
            counters[array[i] + offset]++;
        }
    }

    
}

void CountingSortExtd(int[] array){
    int min = array.Min();
    int max = array.Max();
    int offset = 0 - min;

    int[] counters = new int [max + offset + 1];

    for (int i = 0; i < array.Length; i++){
        counters[array[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++){
        for(int j = 0; j < counters[i]; j++){
            array[index] = i - offset;
            index++;
        }
    }
}

void FillArray (int[] array, int min, int max){
    Random random = new Random();

    for (int i = 0; i < array.Length; i++){
        array[i] = random.Next(min, max);
    }
}

void ShowArray (int[] array){
    foreach (int e in array){
        System.Console.Write($"{e} ");
    }
}

FillArray(ints, 0, 5);
ShowArray(ints);
System.Console.WriteLine();
PrepareParallelCountings(ints);
ShowArray(ints);