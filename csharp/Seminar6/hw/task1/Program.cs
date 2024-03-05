// Задача 1: Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

//                  ::imports::

//                  ::vars::
// Двумерный массив
char[,] chars = {
    {'h', 'e', 'l', 'l', 'o'},
    {'w', 'o', 'r', 'l', 'd'}
};


//                  ::functions::
// Создаём строку из массива
string CreateString (char[,] chars){
    string result = "";

    foreach (char item in chars){
        result += item;
    }
    return result;
}



//                  ::client's code::
// Выводим строку из массива chars
System.Console.WriteLine(CreateString(chars));