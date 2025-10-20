using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation979<T>
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
    sb.Append("[BLANK]\n");
    sb.Append(" .row = ").Append(StringUtil.ToHexString(Row)).Append("\n");
    sb.Append(" .col = ").Append(StringUtil.ToHexString(Column)).Append("\n");
    sb.Append(" .xfindex= ").Append(StringUtil.ToHexString(XFIndex)).Append("\n");
    sb.Append("[/BLANK]\n");
    return sb.ToString();
}
}