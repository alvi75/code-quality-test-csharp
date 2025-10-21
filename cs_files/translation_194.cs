using System;
using System.Collections.Generic;

public class Translation194<T>
{
    public virtual bool HasObject(AnyObjectId id){
    return FindOffset(id) != -1;
}
}