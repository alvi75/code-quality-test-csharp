using System;
using System.Collections.Generic;

public class Translation256<T>
{
    public override V Get(ICharSequence text){
    if (text == null){
        throw new ArgumentNullException("text");
    }
    return default(V);
}
}