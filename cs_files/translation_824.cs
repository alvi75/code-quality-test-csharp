using System;
using System.Collections.Generic;

public class Translation824<T>
{
    public override TokenStream Create(TokenStream @in){
    return new ReverseStringFilter(@in);
}
}