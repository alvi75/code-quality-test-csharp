using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation821<T>
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
    buffer.Append("[SCENARIOPROTECT]\n");
    buffer.Append(" .scenarioProtectType = ").Append(StringUtil.ToHexString(ScenarioProtectType)).Append("\n");
    buffer.Append(" .type = ").Append(StringUtil.ToHexString((int) Type)).Append("\n");
    buffer.Append(" .scenarioId = ").Append(StringUtil.ToHexString(ScenarioId)).Append("\n");
    buffer.Append("[/SCENARIOPROTECT]\n");
    return buffer.ToString();
}
}