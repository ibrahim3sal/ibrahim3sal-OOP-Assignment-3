
using System.Text.RegularExpressions;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string? value)
    {
        return value is not null &&
               Regex.IsMatch(value, @"\A(?:01[0125]\d{8}|\+201[0125]\d{8})\z");
    }

    public static bool IsValidEgyptianNationalId(this string? value)
    {
        return value is not null &&
               Regex.IsMatch(value, @"\A[23]\d{13}\z");
    }
}
