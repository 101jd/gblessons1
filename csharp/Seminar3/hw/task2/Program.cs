int[] numbers = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; 

int amount = 0;

foreach (int number in numbers){
    if (number % 2 == 0){
        amount++;
    }
}

Console.Write(amount);