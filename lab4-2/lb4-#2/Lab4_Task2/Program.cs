using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab4_Task2
{
    class Program
    {
        [DllImport("quadeq.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double countDisc(int a, int b, int c);

        [DllImport("quadeq.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double countRoot(int a, int b, int c, int mod);

        [DllImport("quadeq.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double countPeak(int a, int b, int c, char axis);

        static void Main(string[] args)
        {
            Console.Write("Введите коэффициент a: ");
            string s_a = Console.ReadLine();
            while(!int.TryParse(s_a, out int type) || int.Parse(s_a) == 0)
            {
                 Console.Write("Некорректный ввод, введите число а, не равное нулю: ");
                 s_a = Console.ReadLine();
            }
            int a = int.Parse(s_a);

            Console.Write("Введите коэффициент b: ");
            string s_b = Console.ReadLine();
            while (!int.TryParse(s_b, out int type))
            {
                Console.Write("Некорректный ввод, повторите попытку: ");
                s_b = Console.ReadLine();
            }
            int b = int.Parse(s_b);

            Console.Write("Введите коэффициент c: ");
            string s_c = Console.ReadLine();
            while (!int.TryParse(s_c, out int type))
            {
                Console.Write("Некорректный ввод, повторите попытку: ");
                s_c = Console.ReadLine();
            }
            int c = int.Parse(s_c);

            double D = countDisc(a, b, c);

            if (D > 0)
            {
                Console.WriteLine($"Дискриминант: {D}");
                double x1 = countRoot(a, b, c, 1);
                Console.WriteLine($"Первый корень уравнения: {x1}");
                double x2 = countRoot(a, b, c, 2);
                Console.WriteLine($"Второй корень уравнения: {x2}");
            } else if (D == 0)
            {
                Console.WriteLine($"Дискриминант: {D}");
                double x = countRoot(a, b, c, 1);
                Console.WriteLine($"Единственный корень уравнения: {x}");
            } else
            {
                Console.WriteLine($"Дискриминант: {D}. Уравнение не имеет корней на множестве действительных чисел");
            }

            if(D >= 0)
            {
                double x0 = countPeak(a, b, c, 'X');
                double y0 = countPeak(a, b, c, 'Y');
                Console.WriteLine($"Вершина параболы (x0, y0): ({x0}, {y0})");
            }
        }
    }
}
