using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation21<T>
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
    
    public override void ReadBytes(byte[] b, int offset, int len, bool useBuffer){
    int available = bufferLength - bufferPosition;
    if (len <= available){
        if (len > 0){
            Array.Copy(buffer, bufferPosition, b, offset, len);
        }
        bufferPosition += len;
    }
    else{
        if (available > 0){
            Array.Copy(buffer, bufferPosition, b, offset, available);
            bufferPosition += available;
            len -= available;
            bufferStart += available;
        }
        if (useBuffer && len < bufferSize){
            Refill();
            if (bufferLength < len){
                Array.Copy(buffer, 0, b, offset, bufferLength);
                throw new EndOfStreamException(this);
            }
            else{
                Array.Copy(buffer, 0, b, offset, len);
                bufferPosition = len;
            }
        }
        else{
            long after = bufferStart + bufferPosition + len;
            if (after > length){
                throw new EndOfStreamException(this);
            }
            ReadBytes(b, offset, len, true);
            bufferStart = after;
            bufferPosition = 0;
            bufferLength = 0;
        }
    }
}
}