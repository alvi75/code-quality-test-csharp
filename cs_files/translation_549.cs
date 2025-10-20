using System;
using System.Collections.Generic;

public class Translation549<T>
{
    public override RevFilter Clone(){
    return new MessageRevFilter.PatternSearch(Pattern());
}
}