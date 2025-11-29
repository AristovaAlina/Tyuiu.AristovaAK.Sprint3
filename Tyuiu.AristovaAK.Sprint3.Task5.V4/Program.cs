using Tyuiu.AristovaAK.Sprint3.Task5.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, используя вложенные циклы, которая вычисляет        *");
        Console.WriteLine("* сумму сумм ряда по формуле при x = 5                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 5;
        int start1 = 1;
        int stop1 = 3; 
        int start2 = 1;
        int stop2 = 13;
        Console.WriteLine("Переменная x = " + x);
        Console.WriteLine("Старт шага первой суммы ряда = " + start1);
        Console.WriteLine("Старт шага второй суммы ряда = " + start2);
        Console.WriteLine("Конец шага первой суммы ряда = " + stop1);
        Console.WriteLine("Конец шага второй суммы ряда = " + stop2);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма сумм ряда = " + ds.GetSumSumSeries(x, start1, start2, stop1, stop2));

        Console.ReadKey();
    }
}