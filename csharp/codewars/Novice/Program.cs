string phrase = Console.ReadLine();
string [] words = phrase.Split(' ');
string result = "";

/*
for (int i = 0; i < words.Length; i++){
    if(words[i].ToCharArray().Length >= 5){
        char[] word = words[i].ToCharArray();
        Random.Shared.Shuffle(word);
        foreach (char e in word){
            Console.Write(e);
        }
        Console.Write(' ');
    } else {
        Console.Write($"{words[i]} ");
    }
}
*/

for (int i = 0; i < words.Length; i++){
    if (words[i].ToCharArray().Length >= 5){
        char[] word = words[i].ToCharArray();
        //Random.Shared.Shuffle(word);
        int mid = word.Length / 2;
        int n = 0;
        int m = word.Length - 1;
        char temp;
        while (n < mid && m >= mid){
            temp = word[n];
            word[n] = word[m];
            word[m] = temp;
            n++;
            m--;
        }
        words[i] = string.Concat(word);
    }
    result += words[i] + " ";
}
Console.Write(result);


/*
foreach(string e in words){
    Console.Write($"{e}\n");
}
*/
