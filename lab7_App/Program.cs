using System;
using System.Collections.Generic;

class AutoService<T>
{
    private Queue<T> cars = new Queue<T>();

    public void AddCar(T car)
    {
        cars.Enqueue(car);
        Console.WriteLine($"Додано автомобіль: {car}");
    }

    public void NextCar()
    {
        if (cars.Count > 0)
        {
            T car = cars.Dequeue();
            Console.WriteLine($"Обслуговується: {car}");
        }
        else
        {
            Console.WriteLine("Черга порожня!");
        }
    }

    public void ShowCount()
    {
        Console.WriteLine($"Автомобілів у черзі: {cars.Count}");
    }

    public void ShowQueue()
    {
        Console.WriteLine("Поточна черга:");

        foreach (T car in cars)
        {
            Console.WriteLine(car);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        AutoService<string> service = new AutoService<string>();

        service.AddCar("BMW");
        service.AddCar("Audi");
        service.AddCar("Toyota");

        Console.WriteLine();

        service.ShowCount();
        service.ShowQueue();

        Console.WriteLine();

        service.NextCar();

        Console.WriteLine();

        service.ShowCount();
        service.ShowQueue();

        Console.WriteLine();

        service.NextCar();
        service.NextCar();
        service.NextCar();
    }
}
