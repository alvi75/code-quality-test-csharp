using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation875<T>
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
    
    public override java.nio.FloatBuffer slice(){
    byteBuffer.limit(_limit * libcore.io.SizeOf.FLOAT);
    byteBuffer.position(_position * libcore.io.SizeOf.FLOAT);
    java.nio.ByteBuffer bb = byteBuffer.slice().order(byteBuffer.order());
    java.nio.FloatBuffer result = new java.nio.FloatToByteBufferAdapter(bb);
    byteBuffer.clear();
    return result;
}
}