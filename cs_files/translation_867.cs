using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation867<T>
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
    
    public override java.nio.ShortBuffer put(short[] src, int srcOffset, int shortCount){
    byteBuffer.limit(_limit * libcore.io.SizeOf.SHORT);
    byteBuffer.position(_position * libcore.io.SizeOf.SHORT);
    if (byteBuffer is java.nio.ReadWriteDirectByteBuffer){
        ((java.nio.ReadWriteDirectByteBuffer)byteBuffer).put(src, srcOffset, shortCount);
    }
    else{
        ((java.nio.ReadWriteHeapByteBuffer)byteBuffer).put(src, srcOffset, shortCount);
    }
    this._position += shortCount;
    return this;
}
}