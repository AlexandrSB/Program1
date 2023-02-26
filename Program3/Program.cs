namespace GeekBrains;

internal class Program
{
        static void Main(string[] args)
    {
        int a = 8;
        int b = 12321;
        int[] dot1 = new int[3]{3, 6, 8};
        int[] dot2 = new int[3]{2, 1, -7};

        int[] dot1a = new int[3]{7, -5, 0};
        int[] dot2a = new int[3]{1, -1, 9};

        Console.Clear();

        Console.WriteLine($"This number <{b}> is palindrom: {isPalindrom(b)}");
        Console.WriteLine($"Length of line is: {Math.Round(line3D(dot1a, dot2a), 2)}");
        Console.WriteLine($"{String.Join(" ", getCubes(a))}");
    }

    static bool isPalindrom(int a) {
        String num;

        if (a > 100000) {
            Console.WriteLine("Введите пятизначное число");
            return false;
        }

        num = a.ToString();

        for (int i = 0; i < num.Length / 2; i++) {

            if (num[i] != num[num.Length - i - 1]) {
                return false;
            }

        }

        return true;
    }

    static double line3D(int[] dot1, int[] dot2) {
        return Math.Sqrt(myPow(dot2[0], dot1[0]) + myPow(dot2[1], dot1[1]) + myPow(dot2[2], dot1[2]));
    }

    static double myPow(int a, int b) {
        return Math.Pow(a - b, 2);
    }

    static double[] getCubes(int a) {
        double[] result = new double[a];
        for (int i = 1; i <= a; i++) {
            result[i-1] = Math.Pow(i, 3);
        }

        return result;
    }
}


