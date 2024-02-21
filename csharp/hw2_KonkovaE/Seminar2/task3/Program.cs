/*Принимает на вход целое число из отрезка [10, 99] 
* показывает наибольшую цифру числа.
*/

int num = 42;
int first = num / 10;
int second = num % 10;

if (num > 9 && num < 100){
    if (first > second) {
        Console.WriteLine(first);
    } else {
        Console.WriteLine(second);
    }
} else {
    Console.WriteLine("Число не входит в диапазон");
}