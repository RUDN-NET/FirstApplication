using System;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа печати таблицы значений функции.");
            Console.WriteLine();

            Console.Write("Введите значение начала интервала x1 >");
            var x1_str = Console.ReadLine();
            var x1 = double.Parse(x1_str);

            Console.Write("Введите значение конца интервала x2 >");
            var x2_str = Console.ReadLine();
            var x2 = double.Parse(x2_str);

            Console.Write("Введите значение шага построения таблицы dx >");
            var dx_str = Console.ReadLine();
            var dx = double.Parse(dx_str);

            // Печатаем функцию от 0 до 360 градусов с шагом 1 градус
            ConsoleFunctionPrinter.Print(x1, x2, dx);
        }
    }

    class ConsoleFunctionPrinter
    {
        private static double Function(double x)
        {
            return Math.Sin(x);
        }

        //public    - разрешает доступ извне класса
        //private   - запрещает доступ извне (пользоваться можно только изнутри класса)
        //protected - можно использовать в классе и в наследниках
        //internal  - можно использовать только в пределах текущей сборки (проекте)
        public static void Print(double x1, double x2, double dx)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("  x\tf(x)");
            Console.WriteLine("-----------------------------------------------");

            var x = x1;

            while (x <= x2)
            {
                var y = Function(x * Math.PI / 180);

                //Console.Write("  ");
                //Console.Write(x);
                //Console.Write("\t");
                //Console.WriteLine(y);

                Console.WriteLine("  {0,4}\t{1:0.0##}", x, y);

                x += dx;
            }
        }
    }
}
