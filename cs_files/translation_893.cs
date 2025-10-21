using System;
using System.Collections.Generic;

public class Translation893<T>
{
    public override TokenStream Create(TokenStream input){
    return new EnglishPossessiveFilter(input);
}
}