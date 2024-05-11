internal class Program
{
    delegate string WeekText();
    private static void Main(string[] args)
    {
        string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        int i = 0;
        WeekText first = () => { string day = days[i]; i++; return day; };
        for ( ; ; )
        {
            if (i > 6) i = 0;
            Console.ReadLine();
            Console.WriteLine(first?.Invoke());
        }
    }
}