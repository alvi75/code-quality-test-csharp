using System;
using System.Collections.Generic;

public class Translation347<T>
{
    public sealed override java.nio.ShortBuffer get(short[] dst, int dstOffset, int shortCount){
    if (shortCount > remaining()){
        throw new java.nio.BufferUnderflowException();
    }
    System.Array.Copy(backingArray, offset + _position, dst, dstOffset, shortCount);
    _position += shortCount;
    return this;
}
}