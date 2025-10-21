using System;
using System.Collections.Generic;

public class Translation280<T>
{
    public virtual void IncrementSecondaryProgressBy(int diff){
    lock (this){
        SetSecondaryProgress(mSecondaryProgress + diff);
    }
}
}