// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

//                  ::imports::

//                  ::vars::
System.Console.WriteLine("Enter random string: ");
string input = Console.ReadLine();

//                  ::functions::
bool IsPalindrome (string text){
    for (int i = 0; i < text.Length / 2; i++){
        if (text[i] != text[text.Length - i - 1])
            return false;
    }
    return true;
}


//                  ::client's code::
Console.Clear();
// true or false
System.Console.WriteLine(IsPalindrome(input));