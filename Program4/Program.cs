namespace GeekBrains;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = 5;
        int c = 453;

        int[] arr = new int[] {1, 2, 3, 4, 5, 6};
        int[] pupilsGrowth = new int[] {165, 163, 160, 157, 155, 154};
        int petjaGrowth = 159;

        Console.WriteLine($"{a} to the power of {b} is: {bigPow(a, b)}");
        Console.WriteLine($"The sum of the digits in a number is: {sumOfDigit(c)} ");
        Console.WriteLine($"Position of Petja is: {petja(8, pupilsGrowth, petjaGrowth)}");
        Console.WriteLine($"Reverse to shift {string.Join(" ", supersdvig(arr, 4))}");
    }

    static int bigPow(int a, int b) {
        int num = a;
        for(int i = 1; i < b; i++) {
            a *= num;
        }

        return a;
    }

    static int sumOfDigit(int a) {
        int sum = 0;
        while (a > 0) {
            sum += a % 10;
            a = a / 10;
        }

        return sum;
    }

    static int petja(int countPupils, int[] pupilsGrowth, int petjaGrowth) {
        int counter = 0;

        foreach (int pupil in pupilsGrowth) {
            if (pupil < petjaGrowth) {
                return counter + 1;
            }
            
            counter++;
        }

        return counter;
    }

    static int[] supersdvig(int[] arr, int shift) {
        shift = shift % arr.Length;
        if (shift == 0) { return arr; }
        if (shift > 0) { shift = arr.Length - shift; } 
        else { shift *= -1; }

        //System.Console.WriteLine($"shift = {shift}");

        Array.Reverse(arr, 0, shift);
        //System.Console.WriteLine($"First reverse: {string.Join(" ", arr)}");

        Array.Reverse(arr, shift, arr.Length - shift);
        //System.Console.WriteLine($"Second reverse: {string.Join(" ", arr)}");

        Array.Reverse(arr);
        //System.Console.WriteLine($"Final reverse: {string.Join(" ", arr)}");

        return arr;
    }
}
