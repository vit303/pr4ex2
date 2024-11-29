using pr4ex2;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //массив месяцев
        Month[] months = {
            new Month("January", 1, "Winter"),
            new Month("February", 2, "Winter"),
            new Month("March", 3, "Spring"),
            new Month("April", 4, "Spring"),
            new Month("May", 5, "Spring"),
            new Month("June", 6, "Summer"),
            new Month("July", 7, "Summer"),
            new Month("August", 8, "Summer"),
            new Month("September", 9, "Autumn"),
            new Month("October", 10, "Autumn"),
            new Month("November", 11, "Autumn"),
            new Month("December", 12, "Winter")
        };
        Console.WriteLine("Введите длину строки: ");
        int n = Convert.ToInt32(Console.ReadLine()); 

        //Выбор месяцев с длиной строки равной n
        var monthsWithLengthN = months.Where(month => month.Name.Length == n);
        Console.WriteLine("Месяцы с длиной строки равной " + n + ": " + string.Join(", ", monthsWithLengthN));

        //Выбор только летних и зимних месяцев
        var summerAndWinterMonths = months.Where(month =>
            month.Season == "Summer" || month.Season == "Winter");
        Console.WriteLine("Летние и зимние месяцы: " + string.Join(", ", summerAndWinterMonths));

        //Вывод месяцев в алфавитном порядке
        var sortedMonths = months.OrderBy(month => month.Name);
        Console.WriteLine("Месяцы в алфавитном порядке: " + string.Join(", ", sortedMonths));

        //Подсчет месяцев, содержащих букву 'u' и длиной имени не менее 4-х
        var countMonthsWithU = months.Count(month => month.Name.Contains('u') && month.Name.Length >= 4);
        Console.WriteLine("Количество месяцев, содержащих букву 'u' и длиной не менее 4: " + countMonthsWithU);
    }
}