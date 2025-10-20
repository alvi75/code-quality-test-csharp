using System;
using System.Collections.Generic;

public class Translation190<T>
{
    public override void Serialize(ILittleEndianOutput out1){
    out1.WriteShort(_options);
}
}