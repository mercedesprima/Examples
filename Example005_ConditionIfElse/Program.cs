Console.Write("Введите имя пользователя:  ");
// тип переменной строка
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
   Console.Write("Привет,  ");
   Console.WriteLine(username); 
}