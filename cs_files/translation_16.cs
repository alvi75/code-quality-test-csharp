using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation16<T>
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
    
    public override int read(byte[] buffer, int offset, int length){
    lock (this){
        if (buffer == null){
            throw new System.ArgumentNullException("buffer == null");
        }
        java.util.Arrays.checkOffsetAndCount(buffer.Length, offset, length);
        if (length == 0){
            return 0;
        }
        int copylen = count - pos < length ? count - pos : length;
        {
            for (int i = 0;
            i < copylen;
            i++){
                buffer[offset + i] = (byte)this.buffer[pos + i];
            }
        }
        pos += copylen;
        return copylen;
    }
}
}