// Задача 2: Задайте строку, содержащую латинские буквы 
// в обоих регистрах. Сформируйте строку, в которой 
// все заглавные буквы заменены на строчные.

//                  ::imports::

//                  ::vars::
string hello = "HellO WorlD";

//                  ::functions::
// Меняем регистр
string DownRegister (string text){
    string result = "";
    foreach (char item in text){
        if (char.IsUpper(item)){
            result += char.ToLower(item);
        } else
            result += item;
    }
    return result;
}

//                  ::client's code::
Console.Clear();
// Меняем регистр в hello
System.Console.WriteLine(DownRegister(hello));