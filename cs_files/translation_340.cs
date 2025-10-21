using System;
using System.Collections.Generic;

public class Translation340<T>
{
    public virtual DirCacheEntry GetDirCacheEntry(){
    return currentSubtree == null ? currentEntry : null;
}
}