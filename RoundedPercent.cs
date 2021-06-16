static double RoundedPercent(double x, double y, int splitPos)
{
    if (x > 0 || y > 0)
        return (double)Math.Round(Math.Min(x, y) / Math.Max(x, y), splitPos, MidpointRounding.AwayFromZero);

    return 0d;
}
