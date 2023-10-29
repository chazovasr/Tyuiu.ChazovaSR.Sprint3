using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint3.Task7.V25.Lib;

namespace Tyuiu.ChazovaSR.Sprint3.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу на C#, которая выводит таблицу значений функций:     *");
            Console.WriteLine("* F(x) = cos(x) + 4*x/2 - sin(x) *3*x, (произвести табулирование), f(x)   *");
            Console.WriteLine("* на заданном диапазоне [-5;5] с шагом 1.Произвести проверку деления на 0 *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;



            Console.WriteLine(" Старт шага =  " + startValue);
            Console.WriteLine(" Конец шага  =  " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+--------------+--------------+");
            Console.WriteLine("|     X        |        f(x)  |");
            Console.WriteLine("+--------------+--------------+");
            for (int i=0; i<=len-1; i++)
            {
                Console.WriteLine("|{0,5:d}         |     {1,5:f2}    |", startValue , valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+--------------+--------------+");
            Console.ReadKey();
        }
    }
}
