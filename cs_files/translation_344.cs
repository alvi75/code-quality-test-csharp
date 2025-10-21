using System;
using System.Collections.Generic;

public class Translation344<T>
{
    public override TokenStream Create(TokenStream input){
    return new RussianLightStemFilter(input);
}
}