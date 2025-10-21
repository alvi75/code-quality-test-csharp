using System;
using System.Collections.Generic;

public class Translation945<T>
{
    public virtual E pollFirst(){
    return (_size == 0) ? default(E) : removeFirstImpl();
}
}