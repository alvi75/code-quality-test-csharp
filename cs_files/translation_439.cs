using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation439<T>
{
    // Common stub fields that might be referenced in methods
    private int blockSize = 1024;
    private int upto = 0;
    private byte[] currentBlock = new byte[1024];
    private List<byte[]> blocks = new List<byte[]>();
    private List<int> blockEnd = new List<int>();
    private int field_1_vcenter = 0;
    private int BLOCK_SIZE = 1024;
    private int DEFAULT_SIZE = 16;
    
    public override String ToXml(String tab){
    StringBuilder builder = new StringBuilder();
    builder.Append(tab).Append("<").Append(RecordName).Append(">\n");
    for (IEnumerator iterator = EscherRecords.GetEnumerator();
    iterator.MoveNext();
    ){
        EscherRecord escherRecord = (EscherRecord)iterator.Current;
        builder.Append(escherRecord.ToXml());
    }
    builder.Append(tab).Append("</").Append(RecordName).Append(">\n");
    return builder.ToString();
}
}