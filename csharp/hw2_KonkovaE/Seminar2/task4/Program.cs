/*Принимает натуральное число N, 
* Показывает его цифры через запятую
*/

int N = 1234567;
int res = N;
int iter = 1;

while (res >= 1){
    res /= 10;
    iter *= 10;
}

int aRes = N;
while (iter > 1){
    aRes = N/(iter/10);
    Console.Write(aRes % 10 + ", ");
    iter /= 10;
}