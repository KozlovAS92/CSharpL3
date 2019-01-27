using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Студент Козлов А.С.
//3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
//Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.

namespace KozlovDZ33
{
    class A
    {
        public int numerator1, numerator2, numerator3, divider1, divider2, divider3, simplificationOut, simplificationIn;
        public void Addition (int numerator1, int numerator2, int divider1, int divider2)
        {
            if(divider1 != divider2)
            {
                numerator3 = (numerator1 * divider2) + (numerator2 * divider1);
                divider3 = divider1 * divider2;
            }
            else
            {
                numerator3 = numerator1 + numerator2;
                divider3 = divider1;
            }
        }
        public void Subtraction (int numerator1, int numerator2, int divider1, int divider2)
        {
            if (divider1 != divider2)
            {
                numerator3 = (numerator1 * divider2) - (numerator2 * divider1);
                divider3 = divider1 * divider2;
            }
            else
            {
                numerator3 = numerator1 - numerator2;
                divider3 = divider1;
            }
        }
        public void Multiplication (int numerator1, int numerator2, int divider1, int divider2)
        {
            numerator3 = numerator1 * numerator2;
            divider3 = divider1 * divider2;
        }
        public void Division (int numerator1, int numerator2, int divider1, int divider2)
        {
            numerator3 = numerator1 * divider2;
            divider3 = divider1 * numerator2;
        }
        public void Error1()
        {
            if(divider1 == 0)
            {
                throw new ArgumentException();
            }
        }
        public void Error2()
        {
            if (divider2 == 0)
            {
                throw new ArgumentException();
            }
        }
        public void Simplification (int numerator3, int divider3)
        {
            if(numerator3 > divider3)
            {
                simplificationOut = numerator3 / divider3;
                simplificationIn = numerator3 % divider3;
            }
        }
    }
    class KozlovDZ33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнение задачи 3");
            Console.WriteLine("Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей.");
            Console.WriteLine("Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.");
            A fraction = new A();
            Console.WriteLine("Введите числитель первого числа:");
            fraction.numerator1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите делитель первого числа:");
            string a = Console.ReadLine();
            if (!Int32.TryParse(a, out fraction.divider1))
            {
                Console.WriteLine("Нужно было ввести целое число.");
            }
            else
            {
                try
                {
                    fraction.Error1();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e} Делитель не может быть равен 0");
                }
            }
            Console.WriteLine("Введите числитель второго числа:");
            fraction.numerator2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите делитель второго числа:");
            a = Console.ReadLine();
            if (!Int32.TryParse(a, out fraction.divider2))
            {
                Console.WriteLine("Нужно было ввести целое число.");
            }
            else
            {
                try
                {
                    fraction.Error2();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e} Делитель не может быть равен 0");
                }
            }
            fraction.Addition(fraction.numerator1, fraction.numerator2, fraction.divider1, fraction.divider2);
            Console.WriteLine($"Сложение:({fraction.numerator1})/({fraction.divider1}) + ({fraction.numerator2})/({fraction.divider2}) = {fraction.numerator3}/{fraction.divider3}");
            fraction.Simplification(fraction.numerator3, fraction.divider3);
            if (fraction.numerator3 > fraction.divider3)
            {
                Console.WriteLine($"Упрощение дроби: {fraction.simplificationOut}({fraction.simplificationIn}/{fraction.divider3})");
            }
            fraction.Subtraction(fraction.numerator1, fraction.numerator2, fraction.divider1, fraction.divider2);
            Console.WriteLine($"Вычитание:({fraction.numerator1})/({fraction.divider1}) - ({fraction.numerator2})/({fraction.divider2}) = {fraction.numerator3}/{fraction.divider3}");
            fraction.Simplification(fraction.numerator3, fraction.divider3);
            if (fraction.numerator3 > fraction.divider3)
            {
                Console.WriteLine($"Упрощение дроби: {fraction.simplificationOut}({fraction.simplificationIn}/{fraction.divider3})");
            }
            fraction.Multiplication(fraction.numerator1, fraction.numerator2, fraction.divider1, fraction.divider2);
            Console.WriteLine($"Вычитание:({fraction.numerator1})/({fraction.divider1}) * ({fraction.numerator2})/({fraction.divider2}) = {fraction.numerator3}/{fraction.divider3}");
            fraction.Simplification(fraction.numerator3, fraction.divider3);
            if (fraction.numerator3 > fraction.divider3)
            {
                Console.WriteLine($"Упрощение дроби: {fraction.simplificationOut}({fraction.simplificationIn}/{fraction.divider3})");
            }
            fraction.Division(fraction.numerator1, fraction.numerator2, fraction.divider1, fraction.divider2);
            Console.WriteLine($"Вычитание:({fraction.numerator1})/({fraction.divider1}) / ({fraction.numerator2})/({fraction.divider2}) = {fraction.numerator3}/{fraction.divider3}");
            fraction.Simplification(fraction.numerator3, fraction.divider3);
            if (fraction.numerator3 > fraction.divider3)
            {
                Console.WriteLine($"Упрощение дроби: {fraction.simplificationOut}({fraction.simplificationIn}/{fraction.divider3})");
            }
            Console.ReadKey();
        }
    }
}
