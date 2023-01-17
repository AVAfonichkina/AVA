Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "слава")
{
    Console.WriteLine("Ура, это же мой муж!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}


