using System;
using System.Collections.Generic;

public class Translation551<T>
{
    public virtual bool CanAppendMatch(){
    foreach (Head head in heads){
        if (head != LastHead.INSTANCE){
            return true;
        }
    }
    return false;
}
}