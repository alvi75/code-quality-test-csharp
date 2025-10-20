using System;
using System.Collections.Generic;

public class Translation725<T>
{
    public static NumberRecord ConvertToNumberRecord(KSRecord ksr){
    NumberRecord nr = new NumberRecord();
    nr.Column = ksr.Column;
    nr.Row = ksr.Row;
    nr.XFIndex = ksr.XFIndex;
    nr.Value = ksr.KSNumber;
    return nr;
}
}