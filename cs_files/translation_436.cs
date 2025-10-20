using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation436<T>
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
    
    public static IntList LineMap(byte[] buf, int ptr, int end){
    IntList map = new IntList((end - ptr) / 36);
    map.FillTo(1, int.MinValue);
    for (;
    ptr < end;
    ptr = NextLF(buf, ptr)){
        map.Add(ptr);
    }
    map.Add(end);
    return map;
}
}