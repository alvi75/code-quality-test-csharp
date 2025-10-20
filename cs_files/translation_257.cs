using System;
using System.Collections.Generic;

public class Translation257<T>
{
    public override TokenStream Create(TokenStream input){
    var commonGrams = new CommonGramsFilter(m_luceneMatchVersion, input, commonWords);
    return commonGrams;
}
}