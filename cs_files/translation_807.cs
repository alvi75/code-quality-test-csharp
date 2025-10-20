using System;
using System.Collections.Generic;

public class Translation807<T>
{
    public override java.nio.LongBuffer put(int index, long c){
    checkIndex(index);
    backingArray[offset + index] = c;
    return this;
}
}