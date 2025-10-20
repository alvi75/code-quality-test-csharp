using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation189<T>
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
    
    public virtual int Normalize(char[] s, int len){
    for (int i = 0;
    i < len;
    i++){
        switch (s[i]){
            case 'ä':case 'å':case 'äö':case 'ö':s[i] = 'a';
            break;
            case 'ö':case 'ò':case 'ô':case 'ou':s[i] = 'o';
            break;
            case 'ï':case 'ì':case 'í':case 'î':s[i] = 'i';
            break;
            case 'ü':case 'ù':case 'ú':case 'û':s[i] = 'u';
            break;
        }
    }
    return len;
}
}