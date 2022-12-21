// 1 тип метода: НЕ ПРИНИМАЕТ/НЕ ВОЗВРАЩАЕТ

void Method1()          //без запятой

{
    Console.WriteLine("Автор текста");
}

//Method1();            //пустые скобки!

// 2 тип: ПРИНИМАЕТ/ НЕ ВОЗВРАЩАЕТ

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения"); 

// используя именнованные аргументы:(msg:"Текст сообщения") 

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg:"Новый текст", count:4);

// 3 тип метода: НЕ ПРИНИМАЕТ/ВОЗВРАЩАЕТ

int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
//Console.WriteLine(Year);

// 4 тип метода: ПРИНИМАЕТ/ВОЗВРАЩАЕТ

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;       //  =""; означает пустую строчку
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(4, "повтор текста ");
//Console.WriteLine(res);


// Цикл for

string Method41(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    //инициализация счетчика + проверка условия + инкремент - увеличение счетчика
    {
        result = result + text;
    }
    return result;
}
string res1 = Method41(4, "новый повтор текста ");
//Console.WriteLine(res1);

// ЦИКЛ В ЦИКЛЕ

// вывод таблицы умножения на экран 

/*for (int i = 2; i <= 5; i++)               //внешний цикл - счетчик i         
{
    for (int j = 2; j <= 10; j++)           //внешний цикл - счетчик j  
    {
        Console.WriteLine($"{i} x {j} = {i * j}");      //тело метода
    }
    Console.WriteLine();                    //переход на новую строку в конце внутреннего цикла
}*/

// Задача 1:
// Дан текст. В тексте нужно все пробулы заменить черточками,
// маленькие буквы "к" заменить боольшими "К",
// а большие "С" заменить ммеленькими "с".

string text = "- Я думаю, сказал князь, улыбаясь, - что,"
              + "ежели бы вас послали вместо нашего милого Винцегероде,"
              + "вы бы взяли приступом согласие прусского короля."
              + "Вы так красноречивы. Вы дадите мне чаю?";

//string s ="qwerty"
//           012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}

/*
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

string newText1 = Replace(newText, 'к', 'К');
Console.WriteLine(newText1);

Console.WriteLine();

string newText2 = Replace(newText1, 'С', 'с');
Console.WriteLine(newText2);
*/

// Задача 2: АЛГОРИТМ УПОРЯДОЧЕВАНИЯ ДАННЫХ ВНУТРИ МАССИВА
//  6  8  3  2  1  4  5  7  

// 1. Найти мин элемент в неотсортированном массива.
// 2. Произвести обмен с первой неотсортированной позицией.
// 3. Повторить пока есть неотсортированные элементы.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} - ");
    }
    Console.WriteLine();
}

/*
// 1 способ

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j=i+1; j<array.Length;j++)
        {
            if(array[j]<array[minPosition])
            {
                minPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
*/
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

// 2 способ

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

