using System;
using System.Collections.Generic;

public class Translation574<T>
{
    public static bool[] copyOf(bool[] original, int newLength){
    if (newLength < 0){
        throw new java.lang.NegativeArraySizeException();
    }
    return copyOfRange(original, 0, newLength);
}
}