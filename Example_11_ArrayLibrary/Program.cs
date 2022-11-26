//1. Определить массив из 10 эллементов (по умолчанию заполнен 0)
//2. Вызвали метод FillArray - заполнил массив рандрмными числами
//3. Вызвали метод PrintArray - распечатал массив

/*
void FillArray(int[]collection)    //метод не возвращает - не ставиться return
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int[] array = new int[10];   //создай новый массив, в котором будет 10 элементов

FillArray(array);
PrintArray(array);
*/

//4. Найти конкретный элемент и указать его индекс.

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

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если не находит элемент

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 2);
Console.WriteLine(pos);
