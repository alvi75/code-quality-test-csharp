using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation726<T>
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
    
    public override java.nio.CharBuffer put(char[] src, int srcOffset, int charCount){
    byteBuffer.limit(_limit * libcore.io.SizeOf.CHAR);
    byteBuffer.position(_position * libcore.io.SizeOf.CHAR);
    if (byteBuffer is java.nio.ReadWriteDirectByteBuffer){
        ((java.nio.ReadWriteDirectByteBuffer)byteBuffer).put(src, srcOffset, charCount);
    }
    else{
        ((java.nio.ReadWriteHeapByteBuffer)byteBuffer).put(src, srcOffset, charCount);
    }
    this._position += charCount;
    return this;
}
}