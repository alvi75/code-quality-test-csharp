using System;
using System.Collections.Generic;

public class Translation381<T>
{
    public void Add(FieldInfos other){
    foreach (FieldInfo fieldInfo in other){
        Add(fieldInfo);
    }
}
}