using System;

namespace MyApp 
{
    internal class Program
    {
        class Tank
        {
            public string tank_model { get; set; }
            public string characteristic_tank { get; set; }
            public override string ToString()
            {
                return $"Model tank : {tank_model}, characteristic : {characteristic_tank}";
            }
            public object Clone()
            {
                return this.MemberwiseClone();
            }
        }
            static void Main(string[] args)
        {
            Tank t_34 = new Tank { tank_model = "T 34 ", characteristic_tank = "The tank featured sloped armor,The T-34 was produced in large numbers during World War II." };
            Tank t_54b = new Tank { tank_model = "T 54B", characteristic_tank = "The tank featured sloped armor for improved protection. The tank typically had a crew of four, including a commander, a gunner, a loader, and a driver." };
            Console.WriteLine("Початкові значення:");
            Tank m4_sherman = (Tank)t_34.Clone();
            Console.WriteLine($"Перший танк: {t_34}");
            Console.WriteLine($"Другий танк: {t_54b}");
            m4_sherman.tank_model = "M4 Sherman";
            m4_sherman.characteristic_tank = "The Sherman was powered by a variety of engines, including gasoline and diesel engines. The M4 Sherman was produced in vast numbers during World War II.";
            Console.WriteLine($"Третій танк: {m4_sherman}");
        }
}
    }
