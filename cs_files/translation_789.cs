using System;
using System.Collections.Generic;

public class Translation789<T>
{
    public bool LessThan(TextFragment fragA, TextFragment fragB){
    if (fragA.Score == fragB.Score){
        return fragA.FragNum > fragB.FragNum;
    }
    else{
        return fragA.Score < fragB.Score;
    }
}
}