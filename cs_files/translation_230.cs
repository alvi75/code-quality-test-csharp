using System;
using System.Collections.Generic;

public class Translation230<T>
{
    public virtual NGit.BatchRefUpdate AddCommand(ICollection<ReceiveCommand> cmd){
    commands.UnionWith(cmd);
    return this;
}
}