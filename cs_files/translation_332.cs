using System;
using System.Collections.Generic;

public class Translation332<T>
{
    public override Merger NewMerger(Repository db){
    return new InCoreMerger(db);
}
}