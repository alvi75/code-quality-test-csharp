using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation571<T>
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
    
    public int CompareTo(byte[] bs, int p){
    int cmp;
    cmp = NB.CompareUInt32(w1, NB.DecodeInt32(bs, p));
    if (cmp != 0){
        return cmp;
    }
    cmp = NB.CompareUInt32(w2, NB.DecodeInt32(bs, p + 4));
    if (cmp != 0){
        return cmp;
    }
    cmp = NB.CompareUInt32(w3, NB.DecodeInt32(bs, p + 8));
    if (cmp != 0){
        return cmp;
    }
    cmp = NB.CompareUInt32(w4, NB.DecodeInt32(bs, p + 12));
    if (cmp != 0){
        return cmp;
    }
    return NB.CompareUInt32(w5, NB.DecodeInt32(bs, p + 16));
}
}