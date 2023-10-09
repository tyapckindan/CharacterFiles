internal class Program
{
    private static void Main(string[] args)
    {
        var path = "C:/Users/DELL/Desktop/24.txt";
        var str = File.ReadAllText(path);

        int m = 1,k = 1;
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] != str[i - 1])
                k++;
            else
            {
                m = Max(k, m);
                k = 1;
            }
        }
        Console.WriteLine(m);
    }
    public static int Max(int a, int b)
    {
        return a > b ? a : b;
    }
}