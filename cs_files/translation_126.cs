using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation126<T>
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
    
    public virtual void Add(char[] output, int offset, int len, int endOffset, int posLength){
    if (count == outputs.Length){
        var newOutputs = new char[ArrayUtil.Oversize(outputs.Length + 1, RamUsageEstimator.NUM_BYTES_CHAR)][];
        Array.Copy(outputs, 0, newOutputs, 0, outputs.Length);
        outputs = newOutputs;
    }
    if (count == endOffsets.Length){
        int[] next = new int[ArrayUtil.Oversize(1 + count, RamUsageEstimator.NUM_BYTES_INT32)];
        Array.Copy(endOffsets, 0, next, 0, count);
        endOffsets = next;
    }
    if (count == posLengths.Length){
        int[] next = new int[ArrayUtil.Oversize(1 + count, RamUsageEstimator.NUM_BYTES_INT32)];
        Array.Copy(posLengths, 0, next, 0, count);
        posLengths = next;
    }
    if (outputs[count] == null){
        outputs[count] = new CharsRef();
    }
    outputs[count].CopyChars(output, offset, len);
    endOffsets[count] = endOffset;
    posLengths[count] = posLength;
    count++;
}
}
}