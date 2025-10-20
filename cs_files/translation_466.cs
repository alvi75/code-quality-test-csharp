using System;
using System.Collections.Generic;

public class Translation466<T>
{
    public int ReadUByte(){
    return _rc4.XorByte(_le.ReadUByte());
}
}