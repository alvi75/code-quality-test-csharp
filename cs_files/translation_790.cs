using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation790<T>
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
    
    public virtual void FreeBefore(int pos){
    Debug.Assert(pos >= 0);
    Debug.Assert(pos <= nextPos);
    int newCount = nextPos - pos;
    Debug.Assert(newCount <= count);
    Debug.Assert(newCount <= buffer.Length);
    buffer[start + pos] = (byte)0;
    nextWrite++;
    pos += changeSkip;
    while (changeSkip > 0 && nextWrite < nextPos){
        --changeSkip;
        nextWrite++;
    }
    if (nextWrite == nextPos){
        Reset();
    }
}
}