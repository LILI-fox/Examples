﻿//Нахождение максимального числа с помощью функции:

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;        
}
//      индекс  0  1     2  3    4  5   6  7  8
int[] array = {17,20,16583,42,1565,46,707,82,19};

//array[0] = 12;  как обратиться к массиву и записать в него значение 

//Console.WriteLine(array[4]);    как обратиться к массиву и получить из него значение

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);

