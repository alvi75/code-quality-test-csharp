using System;
using System.Collections.Generic;

public class Translation136<T>
{
    public virtual IErrorNode AddErrorNode(IToken badToken){
    IErrorNodeImpl t = new IErrorNodeImpl(badToken);
    AddChild(t);
    t.Parent = this;
    return t;
}
}