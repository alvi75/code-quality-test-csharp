using System;
using System.Collections.Generic;

public class Translation921<T>
{
    public override java.nio.FloatBuffer slice(){
    return new java.nio.ReadOnlyFloatArrayBuffer(remaining(), backingArray, offset +_position);
}
}