Console.Clear();
bool b = false;
int min = 1;
int max = 100;

while (!b){
    Console.WriteLine($"Загадайте число от {min} до {max}");
    int n = int.Parse(Console.ReadLine()!);
    if (n >= min && n <= max){
        b = true;
    }
}

int GuessNumber (int min, int max){
    //min -= 1;
    int result;
    int mid = (min + max) / 2;

    if (max - min != 1 && mid > 0){
        Console.WriteLine($"Число больше {mid}? y/n");
        char c = char.Parse(Console.ReadLine());
        if (c == 'y'){
            min = GuessNumber(mid, max);
            return min;
        }
        else {
            max = GuessNumber(min-1, mid);
            return max;
        }
    }
    return max;
    
}

Console.WriteLine($"Ответ: {GuessNumber(min, max)}");