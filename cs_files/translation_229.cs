using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation229<T>
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
    
    public short GetGB2312Id(char ch){
    byte[] buffer = new byte[2];
    buffer[0] = (byte)0xFF;
    buffer[1] = (byte)0x00;
    try{
        String strkey = Encoding.GetEncoding("GB2312").GetString(new UTF8Encoder().Encode(ch));
        int len = strkey.Length;
        if (len < 2 || strkey[len - 1] != 's')return -1;
        buffer[2] = (byte)strkey[len - 2];
        buffer[3] = (byte)strkey[len - 1];
        return short.Parse(new string(buffer));
    }
    catch (FormatException ){
        return -1;
    }
}
}