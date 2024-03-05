// Задача 4*: Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

//                  ::imports::

//                  ::vars::
string someText = "Hello World and You All";

//                  ::functions::
// Делаем из стоки массив строк
string[] CreateStringArray (string text){
    int count = 1;
    foreach (char item in text){
        if (item == ' ')
            count ++;
    }

    string[] result = new string[count];
    int j = 0;

    for (int i = 0; i < text.Length; i++){
        if (text[i] == ' ')
            j++;
        result[j] += text[i];
    }
    ReverseArray(result);
    return result;
}

//Разворачиваем массив строк
void ReverseArray (string[] input){
    for (int i = 0; i < input.Length /2; i++){
        string temp = input[i];
        input[i] = input[input.Length -1 -i];
        input[input.Length - 1 - i] = temp;
    }
}

string ReverseString (string input){
    string result = string.Join(" ", CreateStringArray(input));
    return result;
}

//                  ::client's code::
// Проверка создания массива
System.Console.WriteLine(string.Join("\t", CreateStringArray(someText)));
// Разворот
System.Console.WriteLine(ReverseString(someText));