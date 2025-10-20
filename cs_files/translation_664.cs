using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation664<T>
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
    StringBuilder buffer = new StringBuilder();
    buffer.Append("[SXVDEX]\n");
    buffer.Append(" .grbit1 =").Append(StringUtil.ToHexString(grbit1)).Append("\n");
    buffer.Append(" .grbit2 =").Append(StringUtil.ToHexString(grbit2)).Append("\n");
    buffer.Append(" .citmShow =").Append(StringUtil.ToHexString(citmShow)).Append("\n");
    buffer.Append(" .isxdiSort =").Append(StringUtil.ToHexString(isxdiSort)).Append("\n");
    buffer.Append(" .isxdiShow =").Append(StringUtil.ToHexString(isxdiShow)).Append("\n");
    buffer.Append(" .subtotalName =").Append(subtotalName).Append("\n");
    buffer.Append("[/SXVDEX]\n");
    return buffer.ToString();
}
}