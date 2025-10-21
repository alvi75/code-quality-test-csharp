using System;
using System.Collections.Generic;

public class Translation954<T>
{
    public override Merger NewMerger(Repository db){
    return new StrategyOneSided.OneSide(db, treeIndex);
}
}