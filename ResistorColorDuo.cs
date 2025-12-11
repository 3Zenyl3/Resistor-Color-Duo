enum Color
{
    black= 0,
    brown= 1,
    red=2,
    orange= 3,
    yellow= 4,
    green= 5,
    blue= 6,
    violet= 7,
    grey= 8,
    white= 9
}
public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        var first = (int)Enum.Parse(typeof(Color), colors[0]);
        var second = (int)Enum.Parse(typeof(Color), colors[1]);
        return first*10+second;
    }
}
