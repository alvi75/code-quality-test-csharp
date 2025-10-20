using System;
using System.Collections.Generic;

public class Translation938<T>
{
    public virtual int indexOfKey(int key){
    return binarySearch(mKeys, 0, mSize, key);
}
}