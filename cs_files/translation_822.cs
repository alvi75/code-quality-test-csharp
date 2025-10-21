using System;
using System.Collections.Generic;

public class Translation822<T>
{
    public virtual NGit.Api.PushCommand SetThin(bool thin){
    CheckCallable();
    this.thin = thin;
    return this;
}
}