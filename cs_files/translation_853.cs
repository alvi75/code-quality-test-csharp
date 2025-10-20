using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation853<T>
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
    
    public override void Write(ILittleEndianOutput out1){
    out1.WriteByte(sid + PtgClass);
    out1.WriteByte((byte)field_3_string.Length);
    out1.WriteByte(_is16bitUnicode ? 0x01 : 0x00);
    if (_is16bitUnicode){
        StringUtil.PutUnicodeLE(field_3_string, out1);
    }
    else{
        StringUtil.PutCompressedUnicode(field_3_string, out1);
    }
}
}