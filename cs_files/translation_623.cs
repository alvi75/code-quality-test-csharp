using System;
using System.Collections.Generic;

public class Translation623<T>
{
    public long RamBytesUsed(){
    return RamUsageEstimator.AlignObjectSize(3 * RamUsageEstimator.NUM_BYTES_OBJECT_REF) + docIDs.RamBytesUsed() + offsets.RamBytesUsed();
}
}