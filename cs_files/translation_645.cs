using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation645<T>
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
    
    public virtual int Stem(char[] s, int len){
    int numVowels = NumVowels(s, len);
    for (int i = 0;
    i < affixes.Length;
    i++){
        Affix affix = affixes[i];
        if (numVowels > affix.m_vocals && len >= affix.m_affix.Length + 3 && StemmerUtil.EndsWith(s, len, affix.m_affix)){
            len -= affix.m_affix.Length;
            return affix.palatalizes ? Unpalatalize(s, len) : len;
        }
    }
    return len;
}
}