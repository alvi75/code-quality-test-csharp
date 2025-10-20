using System;
using System.Collections.Generic;

public class Translation577<T>
{
    public virtual bool Contains(char[] text, int offset, int length){
    return map.ContainsKey(text, offset, length);
}
}