using System;
using System.Collections.Generic;

public class Translation704<T>
{
    public override TextReader Create(TextReader input){
    return new PersianCharFilter(input);
}
}