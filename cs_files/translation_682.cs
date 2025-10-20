using System;
using System.Collections.Generic;

public class Translation682<T>
{
    public override RevFilter Negate(){
    return NotRevFilter.Create(this);
}
}