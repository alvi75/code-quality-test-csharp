using System;
using System.Collections.Generic;

public class Translation160<T>
{
    public NumberPtg(ILittleEndianInput in1){
    this._value = in1.ReadDouble();
}
}