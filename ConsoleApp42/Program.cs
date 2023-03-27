
using ConsoleApp42.Model;
using ConsoleApp42.Service;

PizzaService<Pizza> Service = new PizzaService<Pizza>();


Console.WriteLine("Hosh geldiniz");
Console.WriteLine("1-pizzalari goster");
Console.WriteLine("2-Pizza Almaq");
int rakam = int.Parse(Console.ReadLine());

if (rakam==1)
{
    Marqarita marqarita = new Marqarita();
    Service.Create1(marqarita);
    Service.Create2(marqarita);
    Service.Show();
    Service.ExtraInfor();
}
else if (rakam==2)
{
    Service.CreatByClient();
}
else
{
    Console.WriteLine("1,2 sece bilersiz");
}
