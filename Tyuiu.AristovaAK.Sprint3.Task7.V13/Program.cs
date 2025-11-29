using Tyuiu.AristovaAK.Sprint3.Task7.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции:           *");
        Console.WriteLine("* F(x) = 3x + 3 - (2x - x)/(cos(x) + 1) (произвести табулирование) f(x)   *");
        Console.WriteLine("* на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на *");
        Console.WriteLine("* ноль. При делении на ноль вернуть 0. Значения занести в массив.         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int start = -5;
        int stop = 5;
        Console.WriteLine($"Числовой отрезок = [{start},{stop}]");

        int len = ds.GetMassFunction(start, stop).Length;

        double[] valueArray = new double[len];
        valueArray = ds.GetMassFunction(start, stop);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("+---------+---------+");
        Console.WriteLine("|    X    |   f(x)  |"); 
        Console.WriteLine("+---------+---------+");
        for (int i = 0; i <= len-1; i++)
        {
            Console.WriteLine("|{0,5:d}    |  {1, 5:f2}  |", start, valueArray[i]);
            start++;
        }

        Console.WriteLine("+---------+---------+");
        Console.ReadKey();
    }
}