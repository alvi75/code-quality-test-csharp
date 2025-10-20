using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation931<T>
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
    
    public static int Match(byte[] b, int ptr, byte[] src){
    if (ptr + src.Length > b.Length){
        return -1;
    }
    for (int i = 0;
    i < src.Length;
    i++, ptr++){
        if (b[ptr] != src[i]){
            return -1;
        }
    }
    return ptr;
}
}