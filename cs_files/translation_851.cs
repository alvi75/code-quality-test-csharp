using System;
using System.Collections.Generic;

public class Translation851<T>
{
    public virtual ObjectId GetPeeledObjectId(){
    return GetLeaf().GetPeeledObjectId();
}
}