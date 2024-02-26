
/*
int[] numbers = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int minRange = 10; 
int maxRange = 90;

int amount = 0;

foreach (int number in numbers){
    if (number >= minRange  && number <= maxRange){
        amount++;
    }
}
Console.Write(amount);
*/


using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
         int amount = 0;

foreach (int number in numbers){
    if (number >= minRange  && number <= maxRange){
        amount++;
    }
}
      return amount;
    }
    
    public static void PrintResult(int[] array)
    {
        
          Console.Write(CountItemsRange(array, 10, 90));
    }

}


//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}