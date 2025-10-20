using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation555<T>
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
    
    public static int Committer(byte[] b, int ptr){
    int sz = b.Length;
    if (ptr == 0){
        ptr += 46;
    }
    while (ptr < sz && b[ptr] == 'p'){
        ptr += 48;
    }
    if (ptr < sz && b[ptr] == 'a'){
        ptr = NextLF(b, ptr);
    }
    return Match(b, ptr, Committer);
}
}