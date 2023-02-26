namespace GeekBrains;

internal class Program
{
    private const string Key = "Monday";

    static void Main(string[] args)
    {
        int a = 104;
        int b = 556542213;
        //int numDayOfWeek = 1;
        Dictionary<String, int> daysOfWeek = new Dictionary<string, int>();

        daysOfWeek.Add("Monday", 1);
        daysOfWeek.Add("Tuesday", 2);
        daysOfWeek.Add("Wednesday", 3);
        daysOfWeek.Add("Thursday", 4);
        daysOfWeek.Add("Friday", 5);
        daysOfWeek.Add("Saturday", 6);
        daysOfWeek.Add("Sunday", 7);

        Console.Clear();

        Console.WriteLine($"Second digit of a number <{a}> is: {getSecondDigitOfNumber(a)}");
        Console.WriteLine("Third gigit of a number <{0}> is: {1}", b, getThirdDigitOfNumber(b));
        Console.WriteLine(getDayOfWeek(daysOfWeek.GetValueOrDefault("Sunday")));
    }

    static int getSecondDigitOfNumber(int a) {
        int result = 0;

        if (a > 1000 || a < 100) {
            Console.WriteLine("Число должно быть трехзначным");
            return 0;
        }

        a = a / 10;
        result = a % 10;

        return result;
    }

    static int getThirdDigitOfNumber (int a) {
        if (a < 100) {
            Console.WriteLine("Третьего числа нет");
            return 0;
        }

        while(a > 1000) {
            a /= 10;
        }

        return a%10;
    }

    static String getDayOfWeek(int a) {
        if (a == 6 || a == 7) {
           return "It is Weekend!!!";
        } else {
            return "It is a work day";
        }
    }
}