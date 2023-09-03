namespace UseDependencyInjectionInDotNET.Extensions;

public static class StringExtension
{
    public static string ToLength(this string value, int length = 10)
    {
        return $"{value}{new string(' ', Math.Max(0, length - value.Length))}";
    }
}
