 static double RoundedPercent(double x, double y, int splitPos)
 {
     if (x > 0 || y > 0)
         return (double)Math.Round(x < y ? x : x > y ? y : x * 100 / x > y ? x : y > x ? y : x,
             splitPos, MidpointRounding.AwayFromZero);
    
     return 0d;
 }
