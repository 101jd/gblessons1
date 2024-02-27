//  Напишите программу, которая бесконечно запрашивает целые числа 
//  с консоли. Программа завершается при вводе символа ‘q’ 
//  или при вводе числа, сумма цифр которого чётная.

Console.Clear();
string input;

bool IsEven (string s) {
    int i;
    if (int.TryParse(s, out i)){
    int number = int.Parse(s);
    int sum = 0;
    while (number >= 1){
        sum += number % 10;
        number /= 10;
    }
    if (sum % 2 == 0){
        return true;
    }
    }
    return false;
}

bool IsQ (string s){
    if (s == "q"){
        return true;
    }
    return false;
}

void AskNumbers(){
    do {
    Console.WriteLine("Введите число:");
    input = Console.ReadLine()!;
         if (IsQ(input)){
            return;
        }
    } while (!IsEven(input));
}

AskNumbers();

