namespace GeekBrains;

internal class Program
{
    static void Main(string[] args) {
        Console.Clear();
        int k1 = 5, b1 = 2, k2 = 9, b2 = 4;

        int v = countPositive();
        System.Console.WriteLine();
        System.Console.WriteLine($"intersection point: {string.Join(" ", intersect(k1, b1, k2, b2))}");
    }

    static int countPositive() {
        String console;
        int num = 0;
        int positiveCounter = 0;
        List<int> usersNum = new List<int>();
        bool toExit = false;

        System.Console.WriteLine("Start cicle");
        while (!toExit) {
            Console.Clear();
            System.Console.WriteLine("Для выхода введите - exit");
            System.Console.WriteLine($"Вы ввели {string.Join(" ", usersNum)}");
            System.Console.WriteLine($"Чисел больше ноля: {positiveCounter}");
            Console.Write("Введите число: ");
            console = Console.ReadLine();
            console = console.ToLower();

            if (console == "exit" || 
                    console == "stop" ||
                    console == "выход") {
                toExit = true;
                break;
            }

            if (int.TryParse(console, out _)) {
                num = Convert.ToInt32(console);
                usersNum.Add(num);   
                if (num > 0) {
                    positiveCounter++;
                }            
            }
        }

        return 0;
    }

    static double[] intersect(int k1, int b1, int k2, int b2) {
        double x = 0, y = 0;

        if ((k1 == k2) && (b1 == b2)) {
            System.Console.WriteLine("Прямые совпадают");
        } else if (k1 == k2) {
            System.Console.WriteLine("Прямые параллельны");
        } else {
            x = ((double) b2 / b1)/(k1 - k2);
            y = (double)(k1 * (b2 - b1))/(k1 - k2) + b1;
        }

        double[] result = new double[]{Math.Round(x, 2), Math.Round(y, 2)};
        return result;
    }
}
