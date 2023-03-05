namespace GeekBrains;

internal class Program
{
    static void Main(string[] args) {
        Console.Clear();


        // Task 54
        printHeader(54);
        task54();


        printHeader(56);
        task56();

        printHeader(58);
        task58();

        printHeader(60);
        task60();

        printHeader(61);
        task61();

        printHeader(62);
        task62();
    }

    static void printHeader(int num) {
        System.Console.WriteLine($"\n******************** Task {num} ********************\n");
    }

    static int[,] inputMatrix(int[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                matrix[i, j] = new Random().Next(1, 99);
            }
        }

        return matrix;
    }

    static int[,,] input3DMatrix(int[,,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                for (int k = 0; k < matrix.GetLength(2); k++) {
                    matrix[i, j, k] = new Random().Next(1, 99);
                }
            }
        }

        return matrix;
    }

    static void printMatrix <T> (T [,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void print3DMatrix <T> (T [,,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                for (int k = 0; k < matrix.GetLength(2); k++) {
                    Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) \t");
                }
                System.Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void task54() {
        int line = 4;
        int column = 5;
        List<int> list = new List<int>();
        int[,] matrix = new int[line, column];

        inputMatrix(matrix);
        printMatrix(matrix);

        for(int i = 0; i < line; i++) {
            for(int j = 0; j < column; j++) {
                list.Add(matrix[i, j]);
            }

            list.Sort();
            list.Reverse();

            for(int j = 0; j < column; j++) {
                matrix[i, j] = list[j];
            }

            list.Clear();
        }

        printMatrix(matrix);
    }

    static void task56() {
        int line = 4;
        int column = 5;
        int sum = 0;
        int lineSum = 0;
        List<int> list = new List<int>();
        int[,] matrix = new int[line, column];

        inputMatrix(matrix);
        printMatrix(matrix);
        System.Console.WriteLine();

        for(int i = 0; i < line; i++) {
            for(int j = 0; j < column; j++) {
                list.Add(matrix[i, j]);
            }

            System.Console.WriteLine($"Sum of {i} line: {list.Sum()}");

            if (sum < list.Sum()) {
                sum = list.Sum();
                lineSum = i;
            };

            list.Clear();
        }

        Console.WriteLine($"\nLine: {lineSum}, Summ: {sum}\n");
    }

    static void task58() {
        int line = 2;
        int column = 2;
        int[,] matrix = new int[line, column];
        int[,] matrix2 = new int[line, column];
        int[,] resultMatrix = new int[line, column];

        inputMatrix(matrix);
        inputMatrix(matrix2);
        printMatrix(matrix);
        printMatrix(matrix2);

        for(int i = 0; i < line; i++) {
            for(int j = 0; j < column; j++) {
                for(int k = 0; k < line; k++) {
                    //System.Console.WriteLine($"res: {resultMatrix[i,j]} = Matrix1 {matrix[i,k]} * Matrix2: {matrix2[k,j]}");
                    resultMatrix[i,j] += matrix[i,k] * matrix2[k,j];
                }
                //System.Console.WriteLine();
            }
        }

        System.Console.WriteLine($"Result matrix is: ");
        printMatrix(resultMatrix);
    }

    static void task60() {
        int x = 2;
        int y = 2;
        int z = 2;
        int[,,] matrix = new int[x, y, z];

        input3DMatrix(matrix);
        print3DMatrix(matrix);
    }

    static float factorial(int n) {
        float i, x = 1;
        for (i = 1; i <= n; i++) {
            x *= i;
        }

        return x;
    }

    static void task61() {
        int str = 5;

        for (int i = 0; i < str; i++)
            {
                for (int j = 0; j <= (str - i); j++) 
                // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
                {
                    Console.Write(" "); 
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" "); // создаём пробелы между элементами треугольника
                    Console.Write(factorial(i) / (factorial(j) * factorial(i - j))); //формула вычисления элементов треугольника
                }
                Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
            }
    }

    static void task62() {
        const int n = 4;
        const int m = 4;
        int[,] matrix = new int[n, m];
 
        int row = 0;
        int col = 0;
        int dx = 1;
        int dy = 0;
        int dirChanges = 0;
        int visits = m;
 
        for (int i = 0; i < matrix.Length; i++) {
            matrix[row, col] = i + 1;
            if (--visits == 0) {
                visits = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
                int temp = dx;
                dx = -dy;
                dy = temp;
                dirChanges++;
            }
 
            col += dx;
            row += dy;
        }

        printMatrix(matrix);
    }
}