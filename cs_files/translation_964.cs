using System;
using System.Collections.Generic;

public class Translation964<T>
{
    public override java.nio.ShortBuffer slice(){
    return new java.nio.ReadWriteShortArrayBuffer(remaining(), backingArray, offset +_position);
}
}