using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation365<T>
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
    
    public override string OutputToString(IObject output){
    if (!(output is IList)){
        return outputs.OutputToString((T)output);
    }
    else{
        IList<T> outputList = (IList<T>)output;
        StringBuilder b = new StringBuilder();
        b.Append('[');
        int size = outputList.Count;
        for (int i = 0;
        i < size;
        i++){
            if (i > 0){
                b.Append(", ");
            }
            b.Append(outputs.OutputToString(outputList[i]));
        }
        b.Append(']');
        return b.ToString();
    }
}
}