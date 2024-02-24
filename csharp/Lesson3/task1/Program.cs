double Calculate (int a, int b, int c, int d){
    double result = (double)(a * b) / (c + d); //15/12
    return result;
}

int val1 = 5;
int val2 = 3;
int val3 = 4;
int val4 = 8;

Console.Write(Calculate(val1, val2, val3, val4));