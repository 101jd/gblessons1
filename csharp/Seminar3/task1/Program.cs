/*

*/

int num = 8;
bool b = false;
int[] arr = {12, 3, 54, 8, 7, 60};

foreach (int e in arr){
    if(e == num){
        b = true;
    }
}
if (b){
    Console.Write("Yes");
} else {
    Console.Write("No");
}