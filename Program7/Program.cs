namespace GeekBrains;

internal class Program
{
    static void Main(string[] args) {
        Console.Clear();
        // Task 47
        System.Console.WriteLine("\n******************** Task 47 ********************\n");

        task47();
        

        // Task 50
        System.Console.WriteLine("\n******************** Task 50 ********************\n");
        System.Console.Write("Введите позицию элемента: ");
        int[] position = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

        task50(position);


        // Task 52
        System.Console.WriteLine("\n******************** Task 52 ********************\n");

        task52();

    }

    static void inputMatrix(double[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                matrix[i, j] = new Random().NextDouble() * new Random().Next(1, 999);
            }
        }
    }

    static int[,] inputMatrix(int[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                matrix[i, j] = new Random().Next(1, 99);
            }
        }

        return matrix;
    }

    static void printMatrix <T> (T [,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write($"{matrix[i, j]:0.00} \t");
            }
            Console.WriteLine();
        }
    }

    // static void printMatrix (int[,] matrix) {
    //     for (int i = 0; i < matrix.GetLength(0); i++) {
    //         for (int j = 0; j < matrix.GetLength(1); j++) {
    //             Console.Write($"{matrix[i, j]} \t");
    //         }
    //         Console.WriteLine();
    //     }
    // }

    static void task47() {
        // System.Console.Write("Введите размер массива: ");
        // int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        // double[,] matrix = new double[size[0], size[1]];

        int[] myArray = new int[] {4, 5};
        double[,] matrix = new double[myArray[0], myArray[1]];

        inputMatrix(matrix);
        printMatrix(matrix);
    }

    static int task50(int[] position) {
        int str = 4;
        int col = 6;
        int[,] mat = inputMatrix(new int[str, col]);
        System.Console.WriteLine();
        printMatrix(mat);

        if (position[0] >= str || position[1] >= col) {
            Console.Write("\nТакой позиций в массиве нет\n");
            return 0;
        }

        Console.Write($"\nНа данной позиции находится элемент: {mat[position[0], position[1]]}\n");
        return mat[position[0], position[1]];
    }

    static void task52() {
        int line = 4;
        int column = 6;
        int[] sum = new int[column];
        double[] avg = new double[column];
        int[,] matrix = inputMatrix(new int[line, column]);
        printMatrix(matrix);


        for(int i = 0; i < line; i++) {
            for(int j = 0; j < column; j++) {
                sum[j] += matrix[i, j];
            }
        }

        System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
        for(int i = 0; i < column; i++) {
            avg[i] = sum[i] / (double) line;
            System.Console.Write($"{avg[i]:0.00}\t");
        }
        System.Console.WriteLine();
    }
}
