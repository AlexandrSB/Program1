namespace GeekBrains;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 25;
        int b = 15;
        int c = 34;

        Console.Clear();
        
        Console.WriteLine($"Max number of {a} and{b} is: {getMaxNumbers1(a, b)}");
        Console.WriteLine($"Max of tree numbers is: {getMaxNumbers2(a, b, c)}");
        Console.WriteLine($"Number {a} is even: {isEven(a)}");
        Console.WriteLine($"Array of evens numbers: {String.Join(" ", getArrayOfEvenNumbers(c))}");
    }

    static int getMaxNumbers1(int a, int b) {
        if (a > b) return a;
        return b;
    }

    static int getMaxNumbers2(int a, int b, int c) {
        if (a > b && a > c) return a;
        if (b > c) return b;
        return c;
    }

    static bool isEven(int a) {
        if ((a & 1) == 1) return false;
        return true;
    }

    static int[] getArrayOfEvenNumbers(int c) {
        int[] result = new int[ c/2 + 1];
        int counter = 0;

        for(int i = 0; i <= c; i += 2) {
            result[counter] = i;
            counter ++;
        }

        return result;
    }
}