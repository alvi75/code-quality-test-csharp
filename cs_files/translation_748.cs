using System;
using System.Collections.Generic;

public class Translation748<T>
{
    public bool HasNext(){
    return this.nextId < this._enclosing.cells.Length;
}
}