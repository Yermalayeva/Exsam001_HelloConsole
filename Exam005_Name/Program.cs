Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "наталья")
{
    Console.Write("Ура, это же Наталья");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}