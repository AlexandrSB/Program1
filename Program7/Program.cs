namespace GeekBrains;

internal class Program
{
    static void Main(string[] args) {
        Console.Clear();

        System.Console.Write("Введите размер массива: ");
        int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        int[,] matrix = new int[size[0], size[1]];
        inputMatrix(matrix);
        printMatrix(matrix);
    }

    static void inputMatrix(int[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                matrix[i, j] = new Random().Next(i, j);
            }
        }
    }

    static void printMatrix (int [,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
    }

    // static double[] createMatrix (int m, int n) {
    //     double[] matrix = new double[];
    // }
}
