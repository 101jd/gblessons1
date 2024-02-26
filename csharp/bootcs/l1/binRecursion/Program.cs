Console.Clear();
bool b = false;
int min = -10;
int max = 10;
int check = min;

while (!b){
    Console.WriteLine($"Загадайте число от {min} до {max}");
    int n = int.Parse(Console.ReadLine()!);
    if (n >= min && n <= max){
        b = true;
    }
}

int GuessNumber (int min, int max){
    int mid = (min + max) / 2;

    if (max - min != 1 && mid >= check){
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