using System;
using System.Collections.Generic;

public class Translation451<T>
{
    public override void Clear(){
    hash = HashFunction.Hash(BytesRef.EMPTY_BYTES);
    base.Clear();
}
}