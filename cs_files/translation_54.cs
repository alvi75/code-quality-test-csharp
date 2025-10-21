using System;
using System.Collections.Generic;

public class Translation54<T>
{
    public override long Skip(long n){
    int s = (int)Math.Min(available(), n);
    ptr += s;
    return s;
}
}