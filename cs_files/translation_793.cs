using System;
using System.Collections.Generic;

public class Translation793<T>
{
    public virtual int CompareTo(BytesRef other){
    return utf8SortedAsUnicodeSortOrder.Compare(this, other);
}
}