using System;
using System.Collections.Generic;

public class Translation426<T>
{
    public virtual int[] Grow(){
    Debug.Assert(bytesStart != null);
    return bytesStart = ArrayUtil.Grow(bytesStart, bytesStart.Length + 1);
}
}