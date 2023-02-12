// Нахождение максимума из 9ти чисел:
// внесли 9 переменных,
// 
// Решение массивом.
// Не нужны переменные:
// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 313;
// 
// array[0] = 12 --> после текущего кода нуевой элемент массива будет равен не 11, а 12

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 }; 

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);



