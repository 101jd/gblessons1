// See https://aka.ms/new-console-template for more information
string str = Console.ReadLine();

string  GetLetters (string s){
    string letters = "";
    foreach (char e in s){
        if(char.IsAsciiLetter(e)){
            letters += e;
        }
    }
    return letters;
}

int[] GetNumbers(string s){
    string numbers = "";
    foreach (char e in s){
        if(char.IsNumber(e)){
            numbers += string.Join("", e);
        }
    }
    char [] chars = numbers.ToCharArray();
    int [] array = new int [chars.Length];
    for (int i = 0; i < array.Length; i++){
        array[i] = int.Parse(chars[i].ToString());
    }

    return array;
}

int GetSum(int[] array){
    int sum = 0;
    foreach (int e in array){
        sum += e;
    }
    return sum;
}

Console.Write(GetLetters(str) + "\n");
int [] ints = GetNumbers(str);
Console.WriteLine(string.Join(" ", ints));
int sum = GetSum(ints);
Console.Write("sum is: " + sum);

// Console.Write("\n" + string.Join(", ", GetNumbers(str)));
// Console.Write("\n" + GetSum(GetNumbers(str)));