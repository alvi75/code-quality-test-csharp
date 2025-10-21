using System;
using System.Collections.Generic;

public class Translation779<T>
{
    public virtual void AddFile(string file){
    CheckFileNames(new string[] {
        file }
        );
        SetFiles.Add(NamedForThisSegment(file));
    }
}