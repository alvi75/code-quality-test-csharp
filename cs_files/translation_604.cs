using System;
using System.Collections.Generic;

public class Translation604<T>
{
    public IList<Head> GetNextHeads(char c){
    if (Matches(c)){
        return newHeads;
    }
    return FileNameMatcher.EMPTY_HEAD_LIST;
}
}