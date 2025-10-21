using System;
using System.Collections.Generic;

public class Translation440<T>
{
    public override TokenStream Create(TokenStream input){
    return new GalicianMinimalStemFilter(input);
}
}