using System;
using System.Collections.Generic;

public class Translation783<T>
{
    public override void Serialize(ILittleEndianOutput out1){
    out1.WriteShort(OptionFlags);
    out1.WriteShort(RowHeight);
}
}