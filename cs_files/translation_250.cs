using System;
using System.Collections.Generic;

public class Translation250<T>
{
    public virtual NGit.Api.RevertCommand Include(AnyObjectId commit){
    return Include(commit.GetName(), commit);
}
}