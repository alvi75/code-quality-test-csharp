using System;
using System.Collections.Generic;

public class Translation262<T>
{
    public override TokenStream Create(TokenStream input){
    return new ElisionFilter(input, articles);
}
}