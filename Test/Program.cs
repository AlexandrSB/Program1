namespace GeekBrains;

internal class Program
{
    static void Main(string[] args) {
        Console.Clear();

        int i = 0, k = 0;
        string[] str = new string[] {"hello", "2", ":)", "world", "dot"};
        string[] result = new string[0];
        string[] tmp;

        foreach(string s in str) {
            if (s.Length <= 3) {
                tmp = result;
                result = new string[result.Length + 1];

                foreach (string s1 in tmp) {
                    result[k] = s1;
                    k++;
                }

                k = 0;                
                result[i] = s;
                i++;
            }
        }

        System.Console.WriteLine($"result array is: [{string.Join(", ", result)}]");
    }
}
