Console.WriteLine("Привет");

while (true) {
    Console.WriteLine("Что ты хочешь узнать 1 - Фио,2 - Группу,3 - Дату ,4 - выход");
    string? a = Console.ReadLine();
    if (a == "1")
    {
        Console.WriteLine("Тимонин Иван");
    } else if (a == "2")
    {
        Console.WriteLine("ИСП-233");
    } else if(a == "3")
    {
        Console.WriteLine(DateTime.Now);
    }
    else
    {
        break;
    }
    
}