using System;
using System.Collections.Generic;

public class Translation104<T>
{
    public RandomAccessFile(string fileName, string mode): base(fileName){
    if (mode.Length != 0){
        throw new System.ArgumentException("mode must be null for non-blocking I/O");
    }
}
}