using System;
using System.Collections.Generic;

public class Translation354<T>
{
    public void WriteLong(long v){
    WriteInt((int)(v >> 0));
    WriteInt((int)(v >> 32));
}
}