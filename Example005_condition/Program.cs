Console.Write ("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower == "Тамерлан")
{
        Console.WriteLine ("Ура, это же Тамерлан!");
}
else
{
    Console.Write ("Привет, "); 
    Console.WriteLine (username);
}