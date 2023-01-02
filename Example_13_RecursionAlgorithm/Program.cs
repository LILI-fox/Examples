// Двумерные массивы
/*
string[,] table = new string[2, 5];
*/
// инициализация через String.Empty - по умолчанию пустые строки
// table[0,0]   table[0,1]   table[0,2]   table[0,3]   table[0,4]
// table[1,0]   table[1,1]   table[1,2]   table[1,3]   table[1,4]
/*
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/

/*
int [,] matrix = new int [3,4];
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();        //переход на новую строку
}
*/

// используем метод для заполнения
/*
int [,] matrix = new int [3,4];

// 1. Инициализируем с ноликами
PrintArray(matrix);
// 2. Заполняем
FillArray(matrix);
// 3. Снова печатаем
PrintArray(matrix);

// метод для печати

void PrintArray(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
         {
             Console.Write($"{matr[i,j]} ");
         }
        Console.WriteLine();
    }
}


// метод для заполнения

void FillArray(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
         {
             matr[i,j] = new Random().Next(1,10);    // полуинтервал [1; 10)
         }
        Console.WriteLine();
    }
}
*/

// Задача - черно-белое изображение
/*
int[,] pic = new int[23, 25];

// координаты закрашенных пикселей

pic[2, 13] = 1;
pic[2, 14] = 1;
pic[3, 12] = 1;
pic[3, 15] = 1;
pic[4, 12] = 1;
pic[4, 15] = 1;
pic[5, 11] = 1;
pic[5, 15] = 1;
pic[6, 11] = 1;
pic[6, 15] = 1;
pic[7, 10] = 1;
pic[7, 14] = 1;
pic[8, 8] = 1;
pic[8, 9] = 1;
pic[8, 14] = 1;
pic[9, 6] = 1;
pic[9, 7] = 1;
pic[9, 13] = 1;
pic[10, 4] = 1;
pic[10, 5] = 1;
pic[10, 6] = 1;
pic[10, 12] = 1;
pic[10, 13] = 1;
pic[10, 14] = 1;
pic[10, 15] = 1;
pic[10, 16] = 1;
pic[10, 17] = 1;
pic[10, 18] = 1;
pic[10, 19] = 1;
pic[10, 20] = 1;
pic[10, 21] = 1;
pic[10, 22] = 1;
pic[10, 23] = 1;
pic[11, 3] = 1;
pic[11, 24] = 1;
pic[12, 2] = 1;
pic[12, 24] = 1;
pic[13, 2] = 1;
pic[13, 17] = 1;
pic[13, 18] = 1;
pic[13, 19] = 1;
pic[13, 20] = 1;
pic[13, 21] = 1;
pic[13, 22] = 1;
pic[14, 1] = 1;
pic[14, 23] = 1;
pic[15, 1] = 1;
pic[15, 23] = 1;
pic[16, 1] = 1;
pic[16, 17] = 1;
pic[16, 18] = 1;
pic[16, 19] = 1;
pic[16, 20] = 1;
pic[16, 21] = 1;
pic[17, 2] = 1;
pic[17, 22] = 1;
pic[18, 2] = 1;
pic[18, 22] = 1;
pic[19, 3] = 1;
pic[19, 16] = 1;
pic[19, 17] = 1;
pic[19, 18] = 1;
pic[19, 19] = 1;
pic[19, 20] = 1;
pic[20, 4] = 1;
pic[20, 5] = 1;
pic[20, 6] = 1;
pic[20, 7] = 1;
pic[20, 8] = 1;
pic[20, 19] = 1;
pic[21, 8] = 1;
pic[21, 9] = 1;
pic[21, 10] = 1;
pic[21, 18] = 1;
pic[22, 12] = 1;
pic[22, 13] = 1;
pic[22, 14] = 1;
pic[22, 15] = 1;
pic[22, 16] = 1;


void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("+");
            }
        }
        Console.WriteLine();
    }
}

PrintImage(pic);

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
    
        FillImage(row - (1), col);
        FillImage(row, col - (1));
        FillImage(row + (1), col);
        FillImage(row, col + (1));
    }
}
FillImage(13, 13);
PrintImage(pic);
*/

// РЕКУРСИЯ

// Задача на вычисление факториала.
/*
double Factorial(double n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1)
    {
        return 1;
    }
    else
    {
        n = n * Factorial(n - 1);
        return n;
    }
}

// Console.WriteLine(Factorial(3));

for (int i = 1; i <= 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}*/

// Числа Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(double n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

for(int i = 1; i<40; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}