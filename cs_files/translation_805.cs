using System;
using System.Collections.Generic;

public class Translation805<T>
{
    public override java.nio.IntBuffer slice(){
    return new java.nio.ReadOnlyIntArrayBuffer(remaining(), backingArray, offset +_position);
}
}