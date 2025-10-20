using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation744<T>
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
    
    public override int Serialize(int offset, byte[] data, EscherSerializationListener listener){
    listener.BeforeRecordSerialize(offset, RecordId, this);
    LittleEndian.PutShort(data, offset, Options);
    LittleEndian.PutShort(data, offset + 2, RecordId);
    LittleEndian.PutInt(data, offset + 4, 8);
    LittleEndian.PutInt(data, offset + 8, field_1_numShapes);
    LittleEndian.PutInt(data, offset + 12, field_2_lastMSOSPID);
    listener.AfterRecordSerialize(offset + 16, RecordId, RecordSize, this);
    return RecordSize;
}
}