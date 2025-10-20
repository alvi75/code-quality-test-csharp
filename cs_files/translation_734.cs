using System;
using System.Collections.Generic;

public class Translation734<T>
{
    public sealed override short get(int index){
    checkIndex(index);
    return backingArray[offset + index];
}
}