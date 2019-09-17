public static class StringUtil
{
    public static string RemoveCharacterWithCount(string str, char removeCharacter, int count)
    {
        if (string.IsNullOrEmpty(str)) return str;

        for (var i = 0; i < count; i++)
        {
            var index = str.IndexOf(removeCharacter);
            str = str.Substring(index + 1);
        }

        return str;
    }
}
