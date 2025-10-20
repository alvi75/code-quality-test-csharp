using System;
using System.Collections.Generic;

public class Translation252<T>
{
    public virtual E pollLast(){
    java.util.MapClass.Entry<E, object> entry = backingMap.pollLastEntry();
    return (entry == null) ? default(E) : entry.getKey();
}
}