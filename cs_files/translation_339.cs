using System;
using System.Collections.Generic;

public class Translation339<T>
{
    public override string ToString(){
    return "<phraseslop value='" + GetValueString() + "'>" + "\n"+ GetChild().ToString() + "\n</phraseslop>";
}
}