using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation884<T>
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
    
    public FeatRecord(RecordInputStream in1){
    futureHeader = new FtrHeader(in1);
    isf_sharedFeatureType = in1.ReadShort();
    reserved1 = (byte)in1.ReadByte();
    reserved2 = in1.ReadInt();
    int cref = in1.ReadUShort();
    cbFeatData = in1.ReadInt();
    reserved3 = in1.ReadShort();
    cellRefs = new CellRangeAddress[cref];
    for (int i = 0;
    i < cellRefs.Length;
    i++){
        cellRefs[i] = new CellRangeAddress(in1);
    }
}
}