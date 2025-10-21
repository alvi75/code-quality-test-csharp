using System;
using System.Collections.Generic;

public class Translation458<T>
{
    public override TokenStream Create(TokenStream input){
    return new GermanMinimalStemFilter(input);
}
}