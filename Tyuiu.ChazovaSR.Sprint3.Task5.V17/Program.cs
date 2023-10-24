﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint3.Task5.V17.Lib;

namespace Tyuiu.ChazovaSR.Sprint3.Task5.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Вложенный цикл                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу на C#, используя вложенный цикл , которая вычисляет  *");
            Console.WriteLine("*произведение ряда по формуле при х = 2.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            Console.WriteLine(" Переменная X =  " + x);
            Console.WriteLine(" Старт шага первой суммы ряда =  " + startValue1);
            Console.WriteLine(" Конец шага первой суммы ряда  =  " + stopValue1);
            Console.WriteLine(" Старт шага второй суммы ряда  =  " + startValue2);
            Console.WriteLine(" Старт шага второй суммы ряда  =  " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма = " + ds.GetSumSumSeries(x,startValue1, startValue2, stopValue1,stopValue2));
            Console.ReadKey();
        }
    }
}
