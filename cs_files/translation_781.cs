using System;
using System.Collections.Generic;

public class Translation781<T>
{
    public void SetPrecedenceFilterSuppressed(bool value){
    if (value){
        this.reachesIntoOuterContext = outerInstance.SetReachesIntoOuterContext(true);
    }
    else{
        this.reachesIntoOuterContext = outerInstance.SetReachesIntoOuterContext(false);
    }
}
}