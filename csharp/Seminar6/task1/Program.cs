// Массивы и строки...
// imports
using static System.Console;

//vars
 string s = "";
WriteLine("Введите строку");
string input = ReadLine()!;
char[] chars = new char [input.Length];
for (int i = 0; i < chars.Length; i++){
    chars[i] = input[i]; 
}

 foreach (char item in chars){
    s += item;
} 
//functions

 foreach (char item in chars){
    Write($"{item} ");
}
System.Console.WriteLine();



//client's code
//Write(s);

string[] strings = {"Hello", "world"};
string test = "Hello, World!";

bool IsLetterGlas (char glas){
    char[] glasses = {'a', 'o', 'i', 'u', 'e'};
    foreach (char c in glasses){
        if (glas == c)
            return true;
    }
    return false;
}

int CountGlas(string text){
    int count = 0;
    char[] ch = text.ToCharArray();
    for (int i = 0; i < ch.Length; i++){
        if (IsLetterGlas(ch[i])){
            count ++;
        }
        
    }
    return count;
} 

System.Console.WriteLine($"It's {CountGlas(test)} glassnych in {test}");


int CountGlasniyeInArray(string text)
{
    int count = 0;
    for(int i = 0; i < text.Length; i++)
    {
        if(text[i] == 'a' || text[i] == 'e' || text[i] == 'o' || text[i] == 'i' || text[i] == 'u')
        {
            count++;
        }
    }
    return count;
}

// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

 bool IsLetterVowels(char vowel)
{
    char[] vowels = {'a','e','i','o','u'};
    foreach(char item in vowels)
    {
        if(vowel == item)
        {
            return true;
        }
    }
    return false;

}



//Write(CountGlas(input));

string Reverse (string input){
    char[] array = input.ToCharArray();
    for (int i = 0; i < array.Length / 2; i++){
        char temp = array[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length - 1 - i] = temp;
    }
    return string.Join("", array);
}

string RevertseString(string input)
{
    string result = "";
    for(int i = input.Length - 1; i > -1; i--)
    {
        result += input[i];
    }
    return result;
}
string hello = "Hello World"; 
System.Console.WriteLine(RevertseString(hello));

 string[] SplitString (string s){

    int count = 1;
    for (int i = 0; i < s.Length; i++){
        if (s[i] == ' '){
            count++;
        }
    }
    string[] answer = new string [count];
    count = 0;
    string result = "";
    for (int i = 0; i < s.Length; i++){
        
        if (s[i] == ' '){
            
            answer[count] = result;
            result = "";
            count ++;
        }
        else {
            result += s[i];
        }
    }
     for (int i = 0; i < result.Length; i++){
        for (int j = 0; j < s.Length; j++){
            while (s[j] != ' '){
                result += s[j];
            }
        }
    } 
     answer[count] = result;
    return answer;
}

string[] lol = SplitString("hello world");
System.Console.WriteLine();

foreach (string e in lol){
    System.Console.WriteLine(e);
} 



Console.WriteLine("string");

string line = ReadLine();

System.Console.WriteLine("symbol");
char c = ReadLine()![0];


    int count = 0;
    foreach (char e in line){
        if (e == c)
            count++;
    }


System.Console.WriteLine($"{count} times!");