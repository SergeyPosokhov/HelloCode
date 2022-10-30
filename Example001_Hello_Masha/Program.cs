Console.WriteLine("Введите Ваше имя ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, наконец-то Машутка с нами");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}