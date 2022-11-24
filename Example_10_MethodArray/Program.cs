int[] array = {19, 42, 37, 43, 8, 52, 67, 72, 8};

int n = array.Length;
int find = 8;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;                  //находит только первый элемент
    } 
    index++;
}