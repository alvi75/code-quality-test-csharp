using System;
using System.Collections.Generic;

public class Translation483<T>
{
    public IndonesianStemFilter(TokenStream input, bool stemDerivational): base(input){
    this.stemDerivational = stemDerivational;
    this.termAtt = AddAttribute<ICharTermAttribute>();
    this.posAtt = AddAttribute<IPositionIncrementAttribute>();
}
}