namespace TriangleLibrary;

public static class TriangleValidator
{
    public static bool IsTriangle(double a, double b, double c)
    {
        return ((a+b>c) && (a+c>b) && (b+c>a));
    }

    public static bool IsEquilateral(double a, double b, double c)
    {
        return (a == b && a == c);
    }

    public static bool IsIsosceles(double a, double b, double c)
    {
        return ((a == b || a == c || b == c) && !(a == b && b == c));
    }

    public static bool IsScalene(double a, double b, double c)
    {
        return a != b && b != c && c != a;
    }
}
