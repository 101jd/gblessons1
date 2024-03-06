// Задачник #1
// S1.1. Вывести на экран число  с точностью до сотых.
double divided = (double)10 / 3;

System.Console.WriteLine($"{divided:.##}");

// S1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
double e = 2.7182818284;

System.Console.WriteLine($"{e:.#}");

// S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры.
// Выводимому числу должно предшествовать сообщение «Вы ввели число».
int ParseNumber()
{
    System.Console.WriteLine("Введите число:");
    string input;
    int number;
    do
    {
        input = Console.ReadLine();
    } while (!int.TryParse(input, out number));
    number = int.Parse(input);

    return number;
}
System.Console.WriteLine($"Вы ввели число {ParseNumber()}");

// S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры.
// После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».

System.Console.WriteLine($"{ParseNumber()} -- вот какое число Вы ввели");

// S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.
int n1 = 1, n2 = 13, n3 = 49;
System.Console.WriteLine($"{n1} {n2} {n3}");

// S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.
int n4 = 7, n5 = 15, n6 = 100;
System.Console.WriteLine($"{n4}  {n5}  {n6}");

// S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
int firstNumber = ParseNumber();
int secondNumber = ParseNumber();
int thirdNumber = ParseNumber();

System.Console.WriteLine($"{firstNumber}  {secondNumber}  {thirdNumber}");

// S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.
int fourthNumber = ParseNumber();

System.Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber} {fourthNumber}");

// S1.9. Вывести на экран числа 50 и 10 одно под другим.
System.Console.WriteLine($"{50}\n{10}");

// S1.10. Вывести на экран числа 5, 10 и 21 одно под другим.
System.Console.WriteLine($"{50}\n{10}\n{21}");

// S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.
System.Console.WriteLine($"{firstNumber}\n{secondNumber}\n{thirdNumber}\n{fourthNumber}");

// S1.12. Составить программу вывода на экран следующей информации:
// 5 10
// 7 см
System.Console.WriteLine($"{5} {10}\n{7} см");

// S1.13. Составить программу вывода на экран следующей информации:
//2 кг
//13 17
System.Console.WriteLine($"{2} кг\n{13} {17}");