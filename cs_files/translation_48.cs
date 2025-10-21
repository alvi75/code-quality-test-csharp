using System;
using System.Collections.Generic;

public class Translation48<T>
{
    public override E previous(){
    if (iterator.previousIndex() >= start){
        return iterator.previous();
    }
    throw new java.util.NoSuchElementException();
}
}