using System;
using System.Collections.Generic;

public class Translation11<T>
{
    public QueryParserTokenManager(ICharStream stream, int lexState): this(stream){
    SwitchTo(lexState);
}
}