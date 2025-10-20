using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation341<T>
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
    
    public override java.nio.IntBuffer put(int[] src, int srcOffset, int intCount){
    java.util.Arrays.checkOffsetAndCount(src.Length, srcOffset, intCount);
    if (intCount > remaining()){
        throw new java.nio.BufferOverflowException();
    }
    {
        for (int i = srcOffset;
        i < srcOffset + intCount;
        ++i){
            put(src[i]);
        }
    }
    return this;
}
}