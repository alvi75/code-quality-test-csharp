using System;
using System.Collections.Generic;

public class Translation993<T>
{
    public override string ToString(){
    StringBuilder s = new StringBuilder();
    s.Append(Constants.TypeString(Type));
    s.Append(' ');
    s.Append(Name);
    s.Append(' ');
    s.Append(CommitTime);
    s.Append(' ');
    AppendCoreFlags(s);
    return s.ToString();
}
}