using System;
using System.Collections.Generic;

public class Translation196<T>
{
    public virtual void SetMultiValued(string dimName, bool v){
    lock (this){
        if (!fieldTypes.TryGetValue(dimName, out DimConfig fieldType)){
            fieldTypes[dimName] = new DimConfig {
                IsMultiValued = v }
                ;
            }
            else{
                fieldType.IsMultiValued = v;
            }
        }
    }
}