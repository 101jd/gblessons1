//                  ::РЕКУРСИЯ::
//t1

int Sum (int number){
    if (number == 0){
        return 0;
    } 

    int sum = number % 10 + Sum(number / 10);
    return sum;
}

System.Console.WriteLine(Sum(2234));

// Задайте значение N. 
//Напишите программу, которая выведет все 
//натуральные числа 
//в промежутке от 1 до N.

void PrintNumbers (int n){
    if (n < 1){
        return;
    }
    
    PrintNumbers(n - 1);
    System.Console.WriteLine(n);
}

PrintNumbers(7);


// Считать строку с консоли, 
//содержащую латинские буквы. 
//Вывести на экран согласные буквы этой строки.

void PrintNotGlass(string s){
    
    if (s.Length < 1){
        return;
    }
    string glass = "iaoue";

    if (char.IsAsciiLetter(s[0]) && !glass.Contains(char.ToLower(s[0]))){
        System.Console.Write($"{s[0]} ");
    }
    PrintNotGlass(s.Substring(1));
    
    

}

string letters = Console.ReadLine();
PrintNotGlass(letters);