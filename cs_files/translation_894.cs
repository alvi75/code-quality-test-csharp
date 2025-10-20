using System;
using System.Collections.Generic;

public class Translation894<T>
{
    public void ClearFormatting(){
    _string = CloneStringIfRequired();
    _string.ClearFormatting();
    AddToSSTIfRequired();
}
}