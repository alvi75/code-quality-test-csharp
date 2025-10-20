using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation418<T>
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
    buffer.Append("[DCONREF]\n");
    buffer.Append(" .options = ").Append("0x").Append(HexDump.ToHex(Options)).Append(" (").Append(Options).Append(" )");
    buffer.Append(Environment.NewLine);
    buffer.Append(" .horizontalBorder = ").Append(IsHorizontalBorder()).Append('\n');
    buffer.Append(" .verticalBorder = ").Append(IsVerticalBorder()).Append('\n');
    buffer.Append(" .border = ").Append(IsBorder()).Append('\n');
    buffer.Append(" .showSeriesKey = ").Append(IsShowSeriesKey()).Append('\n');
    buffer.Append("[/DCONREF]\n");
    return buffer.ToString();
}
}