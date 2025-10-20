using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation318<T>
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
    
    public override long skip(long charCount){
    if (charCount < 0){
        throw new System.ArgumentException("charCount < 0: " + charCount);
    }
    lock (@lock){
        checkNotClosed();
        if (charCount == 0){
            return 0;
        }
        long inSkipped;
        int availableFromBuffer = buf.Length - pos;
        if (availableFromBuffer > 0){
            long requiredFromIn = charCount - availableFromBuffer;
            if (requiredFromIn <= 0){
                pos += charCount;
                return charCount;
            }
            pos += availableFromBuffer;
            inSkipped = @in.skip(requiredFromIn);
        }
        else{
            inSkipped = @in.skip(charCount);
        }
        return inSkipped + availableFromBuffer;
    }
}
}