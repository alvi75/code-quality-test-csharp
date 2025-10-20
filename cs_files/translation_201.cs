using System;
using System.Collections.Generic;

public class Translation201<T>
{
    public virtual RebaseCommand.RebaseResult GetRebaseResult(){
    return this._enclosing.result;
}
}