using System;
using System.Collections.Generic;

public class Translation723<T>
{
    public virtual void incrementProgressBy(int diff){
    lock (this){
        setProgress(mProgress + diff);
    }
}
}