using System;
using System.Collections.Generic;

public class Translation119<T>
{
    public virtual FieldInfo FieldInfo(string fieldName){
    FieldInfo ret;
    byName.TryGetValue(fieldName, out ret);
    return ret;
}
}