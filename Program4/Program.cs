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
        int golbachNumber = 8;

        Console.Clear();

        Console.WriteLine($"{a} to the power of {b} is: {bigPow(a, b)}");
        Console.WriteLine($"The sum of the digits in a number is: {sumOfDigit(c)} ");
        Console.WriteLine($"Position of Petja is: {petja(8, pupilsGrowth, petjaGrowth)}");
        Console.WriteLine($"Reverse to shift {string.Join(" ", supersdvig(arr, 4))}");
        Console.WriteLine($"Summ of numbers {golbachNumber} is: {string.Join(" ", GolbachTeory(golbachNumber))}");

        EvenNumbers eNum = new EvenNumbers();
        foreach (int n in eNum) {
            Console.WriteLine($"Summ of numbers {n} is: {string.Join(" ", GolbachTeory(n))}");
        }
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

    static int[] GolbachTeory(int num) {
        int[] result = new int[2];

        if (num < 2 || num > 1000 || (num & 1) == 1) {
            System.Console.WriteLine($"Число должно быть от 2 до 1000 и четным");
            return result;
        }

        int[] primeNum = new int[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 
            41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 
            113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 
            193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 
            271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 
            359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 
            443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 
            541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 
            619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 
            719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 
            821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 
            911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997
        };

        foreach (int elem in primeNum) {
            var index = Array.FindIndex(primeNum, x => x == num - elem);
            if (index != -1) {
                result[0] = elem;
                result[1] = primeNum[index];
                return result;
            } 
        }

        return result;
    }

    class EvenNumbers {
        public IEnumerator<int> GetEnumerator() {
            for (int i = 0; i < 1000; i += 2) {
                yield return i;
            }
        }
    }
}
