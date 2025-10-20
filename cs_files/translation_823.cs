using System;
using System.Collections.Generic;

public class Translation823<T>
{
    public virtual int CompareTo(SearcherTracker other){
    return other.RecordTimeSec - RecordTimeSec;
}
}