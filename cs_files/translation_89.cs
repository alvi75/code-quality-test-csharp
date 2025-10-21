using System;
using System.Collections.Generic;

public class Translation89<T>
{
    public virtual IQueryNode GetChild(){
    return GetChildren().First();
}
}