using System;
using System.Collections.Generic;

public class Translation592<T>
{
    public static string Join(ICollection<string> parts, string separator){
    return string.Join(separator, parts);
}
}