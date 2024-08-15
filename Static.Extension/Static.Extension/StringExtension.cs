namespace Static.Extension;

static class StringExtension
{
    public static string ToCapitalize(this string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return "";
        string result = Char.ToUpper(value[0]) + value.Substring(1).ToLower();
        return result;
    }
}
