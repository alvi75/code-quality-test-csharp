using System;
using System.Collections.Generic;

public class Translation47<T>
{
    public virtual void Reset(){
    if (!First){
        ptr = 0;
        if (!Eof){
            ParseEntry();
        }
    }
}
}