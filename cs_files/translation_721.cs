using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation721<T>
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
    
    public override java.nio.ByteBuffer read(int length, long position){
    if (position >= size){
        throw new System.IndexOutOfRangeException("Position " + position + " past the end of the file");
    }
    java.nio.ByteBuffer dst;
    if (writable){
        dst = channel.map(java.nio.FileChannel.MapMode.READ_WRITE, position, length);
        @lock.add(dst);
    }
    else{
        dst = java.nio.ByteBuffer.allocate(length);
        int worked = IOUtils.readFully(channel, dst);
        if (worked == -1){
            throw new System.IndexOutOfRangeException("Position " + position + " past the end of the file");
        }
        dst.position(0);
    }
    return dst;
}
}