using System;
using System.Collections.Generic;

public class Translation671<T>
{
    public virtual StashApplyCommand StashApply(){
    return new StashApplyCommand(repo);
}
}