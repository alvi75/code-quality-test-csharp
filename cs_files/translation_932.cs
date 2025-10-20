using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation932<T>
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
    
    public override int FillFields(byte[] data, int offset, IEscherRecordFactory recordFactory){
    int bytesRemaining = ReadHeader(data, offset);
    int pos = offset + 8;
    int size = 0;
    field_1_rectX1 = LittleEndian.GetInt(data, pos + size);
    size += 4;
    field_2_rectY1 = LittleEndian.GetInt(data, pos + size);
    size += 4;
    field_3_rectX2 = LittleEndian.GetInt(data, pos + size);
    size += 4;
    field_4_rectY2 = LittleEndian.GetInt(data, pos + size);
    size += 4;
    bytesRemaining -= size;
    if (bytesRemaining != 0)throw new RecordFormatException("Expected no remaining bytes but got " + bytesRemaining);
    return 8 + size + bytesRemaining;
}
}