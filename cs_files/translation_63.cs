using System;
using System.Collections.Generic;

public class Translation63<T>
{
    public override TokenStream Create(TokenStream input){
    return new DoubleMetaphoneFilter(input, maxCodeLength, inject);
}
}