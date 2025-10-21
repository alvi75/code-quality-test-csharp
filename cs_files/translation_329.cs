using System;
using System.Collections.Generic;

public class Translation329<T>
{
    public TurkishLowerCaseFilter(TokenStream @in): base(@in){
    termAtt = AddAttribute<ICharTermAttribute>();
}
}