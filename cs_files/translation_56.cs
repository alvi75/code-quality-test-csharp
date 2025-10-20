using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation56<T>
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
    
    public override void Serialize(ILittleEndianOutput out1){
    out1.WriteShort(field_1_row);
    out1.WriteShort(field_2_col);
    out1.WriteShort(field_3_flags);
    out1.WriteShort(field_4_shapeid);
    out1.WriteShort(field_6_author.Length);
    out1.WriteByte(field_5_hasMultibyte ? 0x01 : 0x00);
    if (field_5_hasMultibyte){
        StringUtil.PutUnicodeLE(field_6_author, out1);
    }
    else{
        StringUtil.PutCompressedUnicode(field_6_author, out1);
    }
    if (field_7_padding != null){
        out1.WriteByte(field_7_padding & 0xFF);
    }
}
}