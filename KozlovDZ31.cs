using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Студент: Козлов А.С.
//1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;
namespace KozlovDZ31
{
    class CComplex 
    {
        public double re;
        public double im;
        public CComplex CAddition(CComplex a, CComplex b)
        {
            CComplex c = new CComplex
            {
                re = a.re + b.re,
                im = a.im + b.im
            };
            return c;
        }
        public CComplex CSubtraction(CComplex a, CComplex b)
        {
            CComplex c = new CComplex
            {
                re = a.re - b.re,
                im = a.im - b.im
            };
            return c;
        }
        public CComplex CMultiplication(CComplex a, CComplex b)
        {
            CComplex c = new CComplex
            {
                re = (a.re * b.re) - (a.im * b.im),
                im = (a.im * b.re) + (a.re * b.im)
            };
            return c;
        }
        public CComplex CDivision(CComplex a, CComplex b)
        {
            CComplex c = new CComplex
            {
                re = ((a.re * b.re) + (a.im * b.im)) / ((b.re * b.re) + (b.im * b.im)),
                im = ((a.im * b.re) - (a.re * b.im)) / ((b.re * b.re) + (b.im * b.im))
            };
            return c;
        }
    }
    struct SComplex 
    {
        public double re;
        public double im;
        public SComplex SAddition(SComplex a, SComplex b)
        {
            SComplex c;
            c.re = a.re + b.re;
            c.im = a.im + b.im;
            return c;
        }
        public string SPrintAddition(SComplex c)
        {
            string a = $"\nСложение.\nОтвет: {c.re} + {c.im}";
            return a;
        }
        public SComplex SSubtraction(SComplex a, SComplex b)
        {
            SComplex c;
            c.re = a.re - b.re;
            c.im = a.im - b.im;
            return c;
        }
        public string SPrintSubtraction(SComplex c)
        {
            string a = $"\nВычитание.\nОтвет: {c.re} + {c.im}";
            return a;
        }
        public SComplex SMultiplication(SComplex a, SComplex b)
        {
            SComplex c;
            c.re = (a.re * b.re) - (a.im * b.im);
            c.im = (a.im * b.re) + (a.re * b.im);
            return c;
        }
        public string SPrintMultiplication(SComplex c)
        {
            string a = $"\nУмножение.\nОтвет: {c.re} + {c.im}";
            return a;
        }
        public SComplex SDivision(SComplex a, SComplex b)
        {
            SComplex c;
            c.re = ((a.re * b.re) + (a.im * b.im)) / ((b.re * b.re) + (b.im * b.im));
            c.im = ((a.im * b.re) - (a.re * b.im)) / ((b.re * b.re) + (b.im * b.im));
            return c;
        }
        public string SPrintDivision(SComplex c)
        {
            string a = $"\nДеление.\nОтвет: {c.re} + {c.im}";
            return a;
        }
    }
    class KozlovDZ31
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнение задачи №1.\nа) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры");
            Console.WriteLine("\nВведите вещественное число 1(re):");
            double re1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите мнимое число 1 (im):");
            double im1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите вещественное число 2 (re):");
            double re2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите мнимое число 2 (im):");
            double im2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nрезультат работы структуры:");
            SComplex d;
            d.re = re1;
            d.im = im1;
            SComplex e;
            e.re = re2;
            e.im = im2;
            SComplex f;
            f.re = 0;
            f.im = 0;
            Console.WriteLine(f.SPrintAddition(f.SAddition(d, e)));
            Console.WriteLine(f.SPrintSubtraction(f.SSubtraction(d, e)));
            Console.WriteLine(f.SPrintMultiplication(f.SMultiplication(d, e)));
            Console.WriteLine(f.SPrintDivision(f.SDivision(d, e)));
            Console.WriteLine("\nб) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса\nрезультат работы класса:");
            CComplex Cd = new CComplex
            {
                re = re1,
                im = im1
            };
            CComplex Ce = new CComplex
            {
                re = re2,
                im = im2
            };
            Console.WriteLine("\nрезультат работы класса:");
            CComplex C1 = Cd.CAddition(Cd, Ce);
            Console.WriteLine($"\nСложение.\nОтвет: {C1.re} + {C1.im}");
            CComplex C2 = Cd.CSubtraction(Cd, Ce);
            Console.WriteLine($"\nВычитание.\nОтвет: {C2.re} + {C2.im}");
            CComplex C3 = Cd.CMultiplication(Cd, Ce);
            Console.WriteLine($"\nУмножение.\nОтвет: {C3.re} + {C3.im}");
            CComplex C4 = Cd.CDivision(Cd, Ce);
            Console.WriteLine($"\nДеление.\nОтвет: {C4.re} + {C4.im}");
            Console.ReadKey();
        }
    }
}
