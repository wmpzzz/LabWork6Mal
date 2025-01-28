class Program
{
    static void Main()
    {
        Console.WriteLine(GetPower(2, 10));
    }

    public int squareOfSquare(int height = 5)
    {
        return height * height;
    }

    public double squareOfSquare(double height = 5)
    {
        return height * height;
    }

    public int squareOfRectangle(int height = 14, int width = 88)
    {
        return height * width;
    }

    public double squareOfRectangle(double height = 14, double width = 88)
    {
        return height * width;
    }

    public static double GetPower(int n)
    {
        double x = 2;
        double value = x;

        if (n <= 0)
            return -1;

        for (int i = 1; i < n; i++)
            value = value * x;

        return 1 / value;
    }

    public static double GetPower(double x, int n)
    {
        double value = x;

        if (n <= 0)
            return -1;

        for (int i = 1; i < n; i++)
            value = value * x;

        return 1 / value;
    }

    public static double GetDivision()
    {
        double x = 10;
        if (x == 0)
            return -1;

        return 1 / x;
    }

    public static double GetDivision(double x)
    {
        if (x == 0)
            return -1;

        return 1 / x;
    }
}