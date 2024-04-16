using System;

abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double Capacity { get; }
    public abstract double Range { get; }
    public abstract string GetInfo();
}
abstract class Vehicle : Transport
{
    public override abstract double Speed { get; }
    public override abstract double Capacity { get; }
    public override abstract double Range { get; }
    public override string GetInfo()
    {
        return $"Транспорт с параметрами: Скорость - {Speed}, Грузоподъемность - {Capacity}, Дальность - {Range}";
    }
}
class Car : Vehicle
{
    public override double Speed => 70;
    public override double Capacity => 500;
    public override double Range => 600;
    public override string GetInfo()
    {
        return $"Автомобиль грузоподъемностью {Capacity} может проехать {Range}";
    }
}
class Airplane : Vehicle
{
    public override double Speed => 500;
    public override double Capacity => 40000;
    public override double Range => 5000;
    public override string GetInfo()
    {
        return $"Самолет грузоподъемностью {Capacity} может пролететь {Range}";
    }
}
class Ship : Vehicle
{
    public override double Speed => 50;
    public override double Capacity => 50000;
    public override double Range => 6000;
    public override string GetInfo()
    {
        return $"Корабль грузоподъемностью {Capacity} может проплыть {Range}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Airplane airplane = new Airplane();
        Ship ship = new Ship();
        Console.WriteLine(car.GetInfo());
        Console.WriteLine(airplane.GetInfo());
        Console.WriteLine(ship.GetInfo());
    }
}