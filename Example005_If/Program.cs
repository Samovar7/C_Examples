Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
    {
        Console.WriteLine("Ура, Маша пришла!");
    }
else
    {
        Console.WriteLine("Привет " + username);
    }