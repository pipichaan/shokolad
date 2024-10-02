using System;

class Program
{
    static void Main()
    {
        // Инициализация параметров
        Console.WriteLine("Введите количество денег: ");
        int money = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите цену одной шоколадки: ");
        int price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество оберток для обмена на новую шоколадку: ");
        int boom = Convert.ToInt32(Console.ReadLine());

        // Подсчет максимального количества шоколадок
        int maax = max(money, price, boom);

        Console.WriteLine($"Максимально возможное количество шоколадок: {maax}");
    }

    // Метод для подсчета максимального количества шоколадок
    static int max(int money, int price, int boom)
    {

        // Первоначальное количество шоколадок
        int chocolate = money / price;
        int boom2 = chocolate;

        // Заходим в цикл обмена оберток на шоколадки
        while (boom2 >= boom)
        {
            int shok = boom2 / boom;
            chocolate += shok;
            boom2 = shok + (boom2 % boom);
        }

        return chocolate;
    }

    
}