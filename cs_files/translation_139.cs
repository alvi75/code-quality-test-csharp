using System;
using System.Collections.Generic;

public class Translation139<T>
{
    public static TokenFilterFactory ForName(string name, IDictionary<string, string> args){
    return loader.NewInstance(name, args);
}
}