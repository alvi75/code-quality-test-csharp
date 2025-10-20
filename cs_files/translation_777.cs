using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation777<T>
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
    
    public static void WriteUnicodeStringFlagAndData(ILittleEndianOutput out1, String value){
    bool is16Bit = HasMultibyte(value);
    out1.WriteByte(is16Bit ? 0x01 : 0x00);
    if (is16Bit){
        PutUnicodeLE(value, out1);
    }
    else{
        PutCompressedUnicode(value, out1);
    }
}
}