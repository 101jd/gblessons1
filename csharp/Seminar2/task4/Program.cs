﻿/*Принимает натуральное число N, 
* Показывает его цифры через запятую
*/

int N = 123045;
int res = N;
while (res >= 1){
    Console.Write(res % 10 + ", ");
    res /= 10;
}