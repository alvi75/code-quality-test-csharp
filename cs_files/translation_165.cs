using System;
using System.Collections.Generic;

public class Translation165<T>
{
    public override TokenStream Create(TokenStream input){
    return new PortugueseStemFilter(input);
}
}