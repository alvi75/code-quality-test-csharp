using System;
using System.Collections.Generic;

public class Translation67<T>
{
    public virtual int Get(int i){
    if (count <= i){
        throw Sharpen.Extensions.CreateIndexOutOfRangeException(i);
    }
    return entries[i];
}
}