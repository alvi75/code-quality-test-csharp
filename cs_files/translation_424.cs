using System;
using System.Collections.Generic;

public class Translation424<T>
{
    public override float get(int index){
    checkIndex(index);
    return byteBuffer.getFloat(index * libcore.io.SizeOf.FLOAT);
}
}