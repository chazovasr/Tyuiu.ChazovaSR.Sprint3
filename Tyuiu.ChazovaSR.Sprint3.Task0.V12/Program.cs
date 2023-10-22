using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint3.Task0.V12.Lib;

namespace Tyuiu.ChazovaSR.Sprint3.Task0.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Оператор цикла for                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу на C#, используя цикл for, которая вычисляет         *");
            Console.WriteLine("*произведение ряда по формуле, при t=1.                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 13;

            Console.WriteLine(" Переменная X =  " + value);
            Console.WriteLine(" Старт шага =  " + startValue);
            Console.WriteLine(" Конец шага =  " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value,startValue,stopValue));
            Console.ReadKey();
        }
    }
}
