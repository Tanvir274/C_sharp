using System;
using System.Linq;
 
public class Example
{
    public static void Main()
    {
        String s = "SHdRVBAHskaBJSyHfD";
 
        s = String.Concat(s.OrderBy(ch => ch));
 
        Console.WriteLine(s);        // ABBDHHHJRSSVadfksy
    }
}