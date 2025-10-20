using System;
using System.Collections.Generic;

public class Translation42<T>
{
    public int GetNextXBATChainOffset(){
    return GetXBATEntriesPerBlock() * LittleEndianConsts.INT_SIZE;
}
}