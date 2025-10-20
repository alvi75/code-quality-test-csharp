using System;
using System.Collections.Generic;

public class Translation316<T>
{
    public virtual Arc<long?> GetFirstArc(long? arc){
    return arc == null ? null : new Arc<long?>(arc.Value, arc.State);
}
}