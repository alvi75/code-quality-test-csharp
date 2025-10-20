using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation335<T>
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
    buffer.Append("[CFRULE]\n");
    buffer.Append(" .cfRuleType =").Append(StringUtil.ToHexString(CfRuleType)).Append("\n");
    buffer.Append(" .cfRuleState =").Append(StringUtil.ToHexString(CfRuleState)).Append("\n");
    buffer.Append(" .cfRuleFlags =").Append(StringUtil.ToHexString(CfRuleFlags)).Append("\n");
    buffer.Append(" .cfLimit =").Append(StringUtil.ToHexString(CfLimit)).Append("\n");
    buffer.Append(" .cfType =").Append(StringUtil.ToHexString(CfType)).Append("\n");
    buffer.Append(" .cfRuleNumber =").Append(StringUtil.ToHexString(CfRuleNumber)).Append("\n");
    buffer.Append(" .cfLastModifiedOn =").Append(StringUtil.ToHexString(CfLastModifiedOn)).Append("\n");
    buffer.Append("[/CFRULE]\n");
    return buffer.ToString();
}
}