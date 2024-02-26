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
min -= 1;
int mid = (min + max) / 2;
while (max - min != 1) {
    Console.WriteLine($"Число больше {mid}? y/n");
    char c = char.Parse(Console.ReadLine());
    if (c == 'y'){
        min = mid;
        mid = (min + max) / 2;
        //Console.WriteLine(min + " " + mid);
    } else {
        max = mid;
        mid = (min + max) / 2;
        //Console.WriteLine(mid + " " + max);
    }
}
Console.WriteLine($"Ответ {max}");