/*
Дано число от 1 до 100000.
Создать массив.
Заполнить цифрами числа
Старший разряд на 0-м индексе.
Размер массива = кол-ву цифр
*/

int n = 12345;
int temp = n;
int count = 0;
int iter = 1;

while (temp > 0){
    temp = temp/10;
    count++;
    iter *= 10;
    Console.WriteLine(temp);
}
int[] numbers = new int [count];
for(int i = 0; i < numbers.Length; i++){
    numbers[i] = n/(iter/10) % 10;
    iter /=10;
    if (i == numbers.Length - 1){
        Console.Write(numbers[i]);
    } else {
        Console.Write($"{numbers[i]}, ");
      }
}
