using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Студент: Козлов А.С.
//2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
//Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
//б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
//При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
namespace KozlovDZ32
{
    class C
    {
        public string e = "";
        public string d = "Произошла ошибка. Нужно было вводить целые числа.";
        public string a = "";
        int b = 0;
        public int c = 0;
        public List<int> num = new List<int> { };
        public void Metod1()
        {
            do
            {
                a = Console.ReadLine();
                if (!Int32.TryParse(a, out b))
                {
                    e = d;
                    break;
                }
                else if (b == 0)
                {
                    break;
                }
                else
                    {
                    num.Add(b);
                        if ((b != 0) && (b > 0) && (b % 2 != 0)) { c = c + b; }
                    }
            }
            while (b != 0);
        }
    }
    class KozlovDZ32
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнение задачи №2:\nа) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).");
            Console.WriteLine("Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.");
            Console.WriteLine("б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.");
            Console.WriteLine("При возникновении ошибки вывести сообщение.Напишите соответствующую функцию");
            Console.WriteLine("Вводите числа. Для остановки введите 0.");
            C A = new C();
            A.Metod1();
            if (A.e != "")
            {
                Console.WriteLine("Произошла ошибка. Нужно было вводить целые числа.");
            }
            else
            {
                int[] numbers = A.num.ToArray<int>();
                Console.WriteLine("Вывод чисел:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"{numbers[i]}");
                }
                Console.WriteLine($"Сумма нечетных положительных чисел:{A.c}");
            }
            Console.ReadKey();
        }
    }
}
