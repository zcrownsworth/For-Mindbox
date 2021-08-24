using System;

namespace For_Mindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый День! Для получения площади круга введите 1, для получения площади треугольника 2");

            string Figure = Console.ReadLine();
            
            if (Figure == "1") // Круг
            {
                Console.WriteLine("Для получения площади круга введите пожалуйста его радиус");
                double radius = Convert.ToDouble(Console.ReadLine());
                
                double square = Math.PI * (radius*radius);
                Console.WriteLine($"Ваш радиус {square}");
                Console.ReadKey();
            }
            else if (Figure== "2") // Треугольник
            {
                double A, B, C, P, S;
                Console.WriteLine("Для получения площади треугольника введите пожалуйста длинну его трех сторон ");
                Console.WriteLine("Первая сторона");
                A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Вторая сторона");
                B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Третья сторона");
                C = Convert.ToDouble(Console.ReadLine());

                P = (A + B + C) / 2;

                S= Math.Sqrt(P * (P - A) * (P - B) * (P - C));
                Console.WriteLine($"Площадь равна : {S}");
                Console.ReadKey();


            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число");
            }
            
        }

      
    }
}
