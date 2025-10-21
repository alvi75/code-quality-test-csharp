using System;
using System.Collections.Generic;

public class Translation937<T>
{
    public DirectoryReader GetIndexReader(){
    lock (this){
        if (indexReader != null){
            indexReader.IncRef();
        }
        return indexReader;
    }
}
}