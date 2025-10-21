using System;
using System.Collections.Generic;

public class Translation300<T>
{
    public virtual NGit.BatchRefUpdate SetRefLogIdent(PersonIdent pi){
    refLogIdent = pi;
    return this;
}
}