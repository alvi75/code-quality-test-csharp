using System;
using System.Collections.Generic;

public class Translation502<T>
{
    public override java.util.Iterator<E> iterator(){
    object[] snapshot = elements;
    return new java.util.concurrent.CopyOnWriteArrayList.CowIterator<E>(snapshot, 0,snapshot.Length);
}
}