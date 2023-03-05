namespace GeekBrains;

internal class Program
{
    static void Main(string[] args) {
        Console.Clear();

        printHeader(66);
        task66();

        printHeader(68);
        int task = task68();
        System.Console.WriteLine($"{task}");
    }

    static void printHeader(int num) {
        System.Console.WriteLine($"\n******************** Task {num} ********************\n");
    }

    static double task66(int n = 4, int m = 7) {
        double result = (m + n) / 2.0 *(m - n + 1);
        System.Console.WriteLine($"Сумма натуральных чисел от {n} до {m}: {result}");

        return result;
    }

    static int task68(int n = 2, int m = 15) {
        if(n == 0) {
            return m + 1;
        } 

        if (m == 0) {
            return task68(n - 1, 1);
        }

        return task68(n - 1, task68(n, m - 1));
    }
} 