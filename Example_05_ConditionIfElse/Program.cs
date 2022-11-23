Console.WriteLine("Ведите ваше имя ");
string username = Console.ReadLine();

//if(username == "Маша")

if(username.ToLower() == "маша") // без учета регистра
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}