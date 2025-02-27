﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace _1st_Lab
{
    class Program
    {
         static int Factorial(int n)
         {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
         }
        static void Main(string[] args)
        {
            #region task 1.9
            int i = 2;

            double a = 0;

            double n = 0;
            double S = Math.Pow(n, 1) * Math.Pow(5, 1) / 1;
            while (i <= 6)
            {
                a = a * i;
                S += Math.Pow(n, i) * Math.Pow(5, i) / a;

                i++;
                Console.WriteLine(S);
            }
            # endregion

            #region task 1.4
            double s;
            double x = double.Parse(Console.ReadLine());
            s = Math.Cos(x);
            for (i = 1; i <= 6; i++)
            {
                s += Math.Cos((i + 1) * x) / Math.Pow(x, i);
            }
            Console.WriteLine(s);
            #endregion

            #region  task 1.15
            int num1 = 2;
            int num2 = 1;
            for (i = 0; i < 2; i++)
            {
                num1 = num1 + num2;
                num2 = num1 - num2;
            }
            Console.WriteLine(num1 / num2);
            #endregion
            #region task 1.16
            const int b1 = 2;
            int q = 2;
            int stepen = 64;
            Console.WriteLine("На шахматной доске всего 64 клетки");
            Console.WriteLine("НАйдём 64-ый член последовательности");
            double Bn = b1 * Math.Pow(q, stepen - 1);

            Console.WriteLine("Найдем сумму");
            var Sn = ((Bn * q) - b1) / (q - 1);
            Console.WriteLine("Наёдем кол-во граммов");
            double kol = Sn / 15;
            Console.WriteLine(kol);
            Console.WriteLine("Ура!");
            #endregion
            #region task 1.18
            int a0 = 10;
            double kolichtstvo = 0;
            int chasti = 2;
            for (i = 3; i <= 24; i += 3)
            {
                kolichtstvo = a0 * chasti;
                Console.WriteLine($"Часы {i} количество клеток =   kol");





            }
            #endregion

            #region task 2.2
            int n = 4;
            int p = 1;
            for (i = n; ; i += 3)
            {
                if (p * i < 30000)
                {
                    p = p * i;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(n);
            #endregion
            #region task 2.4
            double x = 1;
            double s = 1;

            x = Convert.ToDouble(Console.ReadLine());

            if (x >= 1)
                Console.WriteLine("Решение не верное!");
            else
            {
                for (i = 0; Math.Pow(x, i) > 0.0001; i++)
                {
                    s += Math.Pow(x, i);

                }
                Console.WriteLine("s " + s);
            }
            Console.ReadKey();
            #endregion
            #region task 2.8.a

            double d = 10;
            double doroga = 10;
            double shag = 1.1;
            int ddni = 7;
            for (int i = 1; i < ; i++)
            {
                doroga = doroga * shag;
                s = s + doroga;
            }
            Console.WriteLine(s);
            #endregion

            #region task 2.8.b

            double f = 0;
            doroga = 10;
            ddni = 0;
            shag = 1.1;
            while (f < 100)
            {
                f += doroga;
                doroga = doroga * shag;
                ddni++;
            }
            Console.WriteLine(ddni);

            #region task 2.8.B
            s = 0;
            doroga = 10;
            ddni = 1;
            while (s < 20)
            {
                s = s + doroga;
                doroga = doroga * shag;
                ddni++;
            }
            Console.WriteLine(ddni);
            #endregion




            #region task 3.1
            double e = 0.0001;

            double s = 0;
            double n = 0;
            int i = 1;
            double y = 0;

            double a = 0;
            for (a = 0.1; a <= 1; a += 0.1)
            {

                do
                {
                    y = Math.Cos(a);

                    n = Math.Pow(-1, i) * Math.Pow(a, 2 * i) / Factorial(2 * i);
                    i = i + 1;
                }
                while (n > e);
                {
                    s += n;
                }
                Console.WriteLine($" Переменная: {a} Сумма: {s} Член последовательности: {n} абсцисса {y}");
            }
            #region task 3.7
            double e = 0.0001;

            double s = 0;
            double n = 0;
            int i = 1;
            double y = 0;

            double a = 0;
            for (a = 0.1; a <= 1; a += 0.05)
            {

                do
                {
                    y = (Math.Exp(a) + Math.Exp(-a)) / 2;


                    n = Math.Pow(-1, i) * Math.Pow(a, 2 * i) / Factorial(2 * i);
                    i = i + 1;
                }
                while (n > e);
                {
                    s += n;
                }
                Console.WriteLine($" Перменная: {a} Сумма: {s} Член последовательности : {n} абсцисса: {y}");




            }
            #endregion
        } 
     }
}
