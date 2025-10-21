using System;
using System.Collections.Generic;

public class Translation118<T>
{
    public virtual StashCreateCommand StashCreate(){
    return new StashCreateCommand(repo);
}
}