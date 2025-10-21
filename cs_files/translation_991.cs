using System;
using System.Collections.Generic;

public class Translation991<T>
{
    public SinglePositionTokenStream(string word){
    singleTerm = new Term(word, null);
    termAtt = AddAttribute<ICharTermAttribute>();
    posIncrAtt = AddAttribute<IPositionIncrementAttribute>();
}
}