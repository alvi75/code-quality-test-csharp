using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation953<T>
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
    
    public ChartFRTInfoRecord(RecordInputStream in1){
    rt = in1.ReadShort();
    grbitFrt = in1.ReadShort();
    verOriginator = in1.ReadByte();
    verWriter = in1.ReadByte();
    int cCFRTID = in1.ReadShort();
    rgCFRTID = new CFRTID[cCFRTID];
    for (int i = 0;
    i < cCFRTID;
    i++){
        rgCFRTID[i] = new CFRTID(in1);
    }
}
}