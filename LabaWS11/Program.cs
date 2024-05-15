internal class Program
{
    delegate string WeekText();
    private static void Main(string[] args)
    {
        string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        int a = 0;
        WeekText first = () => { if (a > 6) a = 0; string day = days[a]; a++; return day; };
        for (int i = 0; i <= 10 ; i++)
        {
            Console.WriteLine(first?.Invoke());
        }
    }
}