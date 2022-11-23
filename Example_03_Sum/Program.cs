//int numberA = 6584;
//int numberB = 464654;

int numberA = new Random().Next(1, 10); //1,2,3...9
Console.Write(numberA);
Console.Write(" + ");
int numberB = new Random().Next(1, 10);
Console.Write(numberB);
Console.Write(" = ");
int result = numberA + numberB;

Console.WriteLine(result);

