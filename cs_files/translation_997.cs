using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation997<T>
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
    buffer.Append("[SERIESLIST]\n");
    buffer.Append(" .numSeries = ").Append("0x").Append(HexDump.ToHex(NumSeries)).Append(" (").Append(NumSeries).Append(" )");
    buffer.Append(Environment.NewLine);
    buffer.Append(" .listType = ").Append("0x").Append(HexDump.ToHex(ListType)).Append(" (").Append(ListType).Append(" )");
    buffer.Append(Environment.NewLine);
    buffer.Append(" .hasMultibyte = ").Append(IsMultibyte).Append('\n');
    buffer.Append(" .language = ").Append("0x").Append(HexDump.ToHex(LanguageCode)).Append(" (").Append(LanguageCode).Append(" )");
    buffer.Append(Environment.NewLine);
    buffer.Append("[/SERIESLIST]\n");
    return buffer.ToString();
}
}