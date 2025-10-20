using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation113<T>
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
    
    public static byte[] ToBigEndianUtf16Bytes(char[] chars, int offset, int length){
    byte[] result = new byte[length * 2];
    int end = offset + length;
    int resultIndex = 0;
    for (int i = offset;
    i < end;
    ++i){
        char ch = chars[i];
        result[resultIndex++] = (byte)((uint)ch >> 8);
        result[resultIndex++] = unchecked((byte)ch);
    }
    return result;
}
}