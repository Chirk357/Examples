// Имеется одномерный массив array из n элементов, требуется
// найти элемент массива, равный find
    //  1. Установить счетчик index в позицию 0
    //  2. Если array [index] = find, алгоритм завершил работу
    //  успешно.
    //  3. Увеличить index на 1
    //  4. Если index < n, то перейти к шагу 2. В противном случае
    //  алгоритм завершил работу безуспешно.

// Решение через МЕТОД.
// new int [10] --> Означает: создай новый массив с 10ю элементами.
// По умолчанию там нули.
// FillArray - название массива
// collection - параметр=аргумент
// collection[index] = new Random().Next(1, 10) --> берем аргумент collection с определенным индексом, 
// кладем туда новое случайное число из диапазона 1-10.
// void FillArray - метод = функция, которая заполняет массив
// void PrintArray - метод = функция, которая печатает массив
// FillArray(array), PrintArray(array) --> вызов метода
// Мы сделали: 1. определили массив int[] array = new int [10], потом заполнили его и напечатали
    // FillArray(array);
    // array[4] = 4;
    // array[6] = 4; --> чтобы 4ки были под индексами 4 и 6


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }


}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array); 
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);