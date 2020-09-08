using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApplication
{
    // Ctrl+K,D
    class FirstTestClass
    {
        public static void Test()
        {
            Console.WriteLine("Первая программа!"); // Вывод текстовой информации на консоль

            // Вывод пустой строки (перенос курсора на следующую строку)
            Console.WriteLine();

            // Вывод численных значений
            Console.WriteLine(42);
            Console.WriteLine(3.14159265358979);

            Console.WriteLine("Hello World!");

            // Вывод данных без переноса курсора на следующую строку
            Console.Write("Введите строку >");

            // Считывание введёной строки
            string str = Console.ReadLine();

            Console.Write("Пользователь ввёл строку:");
            Console.WriteLine(str);

            string s1 = "Hello World!";
            string s2, s3, s4, s5 = "qwe", s6 = s5;

            s1 = "qwe";

            string num_str = "123";

            char ch1 = 'a';
            char ch2 = s1[0];

            byte b1 = 255; // uint8 - 1 байт без знака
            sbyte sb1 = -128; // int8 - 1 байт со знаком

            b1 = byte.Parse(num_str);
            sb1 = sbyte.Parse(num_str);

            short sh1 = 4; // int16 - 2 байта со знаком
            ushort ush1 = 5; // uint16 - 2 байта без знака

            sh1 = short.Parse(num_str);
            ush1 = ushort.Parse(num_str);

            // целое число по умолчанию
            int i1 = 42; //int32 - 4 байта со знаком
            uint ui1 = 13; // uint32 - 4 байта без знака

            i1 = int.Parse(num_str);
            ui1 = uint.Parse(num_str);

            long l1 = 1234567890; // int64 - 8 байт со знаком
            ulong ul1 = 123456789; // uint64 - 8 байт без знака

            l1 = long.Parse(num_str);
            ul1 = ulong.Parse(num_str);

            //BigInteger

            // основной для вещественных чисел
            double x = 3.14; // 8 байт
            float y = 15.3f; // 4 байта

            x = double.Parse(num_str);
            y = float.Parse(num_str);

            // Двоично-десятичное кодирование вещественных чисел
            decimal dec = 35.36m;

            dec = decimal.Parse(num_str);

            bool b_1 = true;
            bool b_2 = false;

            var bool_str = "true";
            b_1 = bool.Parse(bool_str);

            var a1 = "Hello World";
            var a2 = 15;
            var b4 = 3.14;
            var b7 = b4 > 5;

            var string_value = dec.ToString();

            /* ------------------------------------------------------------------------
             
                Управляющие конструкции

               ------------------------------------------------------------------------
             */

            var x0 = 3.14;
            if (x0 > 5)
                Console.WriteLine("Значение x0 больше 5!");

            if (x0 > 3)
            {
                Console.WriteLine("Значение x0 больше 3!");
                Console.Write("Введите новое значение x0 >");
                var x0_str = Console.ReadLine();
                // Разбор строки и превращение её в вещественное число
                x0 = double.Parse(x0_str);
            }
            else
            {
                Console.WriteLine("Значение x0 меньше, либо равно 3");
            }

            if (x0 > 3) // строго больше
                Console.WriteLine("123");
            else if (x0 >= 0) // больше, либо равно
            {

            }
            else if (x0 == -1) // оператор равенства
            {

            }
            else if (x0 != -5) // неравно
            {

            }
            else
            {

            }

            // Итерационный цикл
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Итерация цикла for i=" + i);
            }

            Console.WriteLine();
            for (int j = 10; j >= 0; j--)
            {
                Console.WriteLine("Итерация цикла for j=" + j);
            }

            var i5 = 5;

            // Цикл с предусловием
            while (i5 > 0)
            {
                Console.WriteLine("Значение i5=" + i5);
                i5--; // i5 = i5 - 1;
            }

            Console.WriteLine();

            // Цикл с постусловием
            do
            {
                Console.WriteLine("Значение i5=" + i5);

                i5 += 2; // i5 = i5 + 2;
            }
            while (i5 < 10);

            Console.WriteLine();

            int[] int_array = new int[10];
            for (var i = 0; i < 10; i++)
                int_array[i] = i + 3;

            foreach (int value in int_array)
            {
                Console.WriteLine("Значение элемента массива " + value);
            }

            string[] s10 = new string[10];
            s10[4] = "QWE";

            bool[] bbb = new bool[20];
        }
    }
}
