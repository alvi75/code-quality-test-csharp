using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation309<T>
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
    
    public override void Decode(byte[] blocks, int blocksOffset, int[] values, int valuesOffset, int iterations){
    if (bitsPerValue > 32){
        throw new System.NotSupportedException("Cannot decode " + bitsPerValue + "-bits values into an int[]");
    }
    for (int i = 0;
    i < iterations;
    ++i){
        long block = ReadInt64(blocks, blocksOffset);
        blocksOffset += 8;
        valuesOffset = Decode(block, values, valuesOffset);
    }
    int remainingBlocks = (blocks.Length - blocksOffset) / 8;
    Debug.Assert(remainingBlocks >= 0);
    Debug.Assert(remainingBlocks <= m_maxBlocks);
    if (remainingBlocks > 0){
        blocks[blocksOffset++] = 0;
    }
    _valuesAgg.Decode(blocks, blocksOffset, values, valuesOffset, remainingBlocks);
}
}