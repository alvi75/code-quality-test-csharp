using System;
using System.Collections.Generic;

public class Translation524<T>
{
    public PersianCharFilterFactory(IDictionary<string, string> args): base(args){
    if (args.Count > 0){
        throw new System.ArgumentException("Unknown parameters: " + args);
    }
}
}