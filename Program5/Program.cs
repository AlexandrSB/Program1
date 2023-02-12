namespace GeekBrains;

internal class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] array = new int[10];
        double[] doubleArray = new double[10];
        int[] vasjaArr = new int[] {4, 16, 19, 31, 2};
        int[] vasjaArr2 = new int[] {29, 4, 7, 12, 15, 17, 24, 1};


        for (int counter = 0; counter < array.Length; counter++) {   
            array[counter] = rnd.Next(100, 999);
        }

        for (int i = 0; i < doubleArray.Length; i++) {
            doubleArray[i] = Math.Round(rnd.NextDouble(), 2);
        }

        System.Console.WriteLine($"34 Count of even numbers is: {evenNumbersInArray(array)}");
        System.Console.WriteLine($"Summ of elements in odd position is: {summOfElem(array)}");
        System.Console.WriteLine($"Diff between Max and Min of arrays {Math.Round(diffOfMaxAndMin(doubleArray), 2)}");

        vasja(vasjaArr2);
    }

    static int evenNumbersInArray(int[] arr) {
        int counter = 0;

        foreach(int i in arr) {
            if((i & 1) != 1) {
                counter++;
            }
        }

        return counter;
    }

    static int summOfElem(int[] arr) {
        int summ = 0;

        for (int i = 1; i < arr.Length; i += 2) {
            summ += arr[i];
        }

        return summ;
    }

    static double diffOfMaxAndMin(double[] arr) {
        return arr.Max() - arr.Min();
    }

    static void vasja(int[] arr) {
        List<int> evens = new List<int>();
        List<int> odds = new List<int>();

        foreach(int i in arr) {
            if ((i & 1) != 1) {
                evens.Add(i);
            } else {
                odds.Add(i);
            }
        }

        System.Console.WriteLine(string.Join(" ", odds));
        System.Console.WriteLine(string.Join(" ", evens));
        
        if (evens.Count > odds.Count) {
            System.Console.WriteLine("Yes");
        } else {
            System.Console.WriteLine("No");
        }
    }
}
