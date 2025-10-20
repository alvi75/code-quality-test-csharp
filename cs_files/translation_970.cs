using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation970<T>
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
    sb.Append("[SXPI]\n");
    for (int i = 0;
    i < fieldInfos.Length;
    i++){
        sb.Append(" .").Append(fieldInfos[i].Name).Append(" = ").Append(fieldInfos[i].Value).Append("\n");
    }
    sb.Append("[/SXPI]\n");
    return sb.ToString();
}
}