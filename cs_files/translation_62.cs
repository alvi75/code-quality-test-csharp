using System;
using System.Collections.Generic;

public class Translation62<T>
{
    public override bool remove(object o){
    lock (mutex){
        return c.remove(o);
    }
}
}