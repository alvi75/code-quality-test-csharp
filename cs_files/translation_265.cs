using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation265<T>
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
    
    public override String ToString(){
    StringBuilder sb = new StringBuilder();
    sb.Append(GetType().Name).Append(" [ARRAY]\n");
    sb.Append(" range=" + Range.ToString() + "\n");
    sb.Append(" options=" + Options + "\n");
    sb.Append(" notUsed=" + Field3NotUsed + "\n");
    sb.Append(" formula:").Append("\n");
    if (_formula != null){
        sb.Append(_formula.ToString());
    }
    sb.Append("]");
    return sb.ToString();
}
}