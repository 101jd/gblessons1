int RisedToPower (int number, int power){
    int n = 1;
    int result = number;
    while (n < power){
        result *= number;
        n++;
    }
    return result;
}

void PrintSquares (int limit){
    int i = 1;
    while (i <= limit){
        Console.Write($"{i*i} ");
        i++;
    }
}

Console.WriteLine(RisedToPower(2, 2));
Console.WriteLine(RisedToPower(3, 3)); 
Console.WriteLine(RisedToPower(2, 5));
Console.WriteLine(RisedToPower(8, 1));

PrintSquares(100);