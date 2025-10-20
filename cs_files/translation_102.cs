using System;
using System.Collections.Generic;

public class Translation102<T>
{
    public override TokenStream Create(TokenStream input){
    return new HyphenatedWordsFilter(input);
}
}