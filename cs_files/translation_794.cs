using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation794<T>
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
    if (len > 4 && StemmerUtil.EndsWith(s, len, "es")){
        len--;
    }
    if (len > 5 && (StemmerUtil.EndsWith(s, len, "ene") || (StemmerUtil.EndsWith(s, len, "ane") && UseNounPhraseStyles))){
        return len - 3;
    }
    if (len > 4 && (StemmerUtil.EndsWith(s, len, "er") || StemmerUtil.EndsWith(s, len, "en") || StemmerUtil.EndsWith(s, len, "et") || (StemmerUtil.EndsWith(s, len, "ar") && UseNounPhraseStyles)){
        return len - 2;
    }
    if (len > 3){
        switch (s[len - 1]){
            case 'a':case 'e':return len - 1;
            break;
            case 'i':case 'o':case 'u':for (int i = 0;
            i < len - 1;
            i++){
                if (StemmerUtil.IsVowel(s[i]) || StemmerUtil.IsVowel(s[i + 1])){
                    s[i] = 'y';
                }
            }
            break;
        }
    }
    return len;
}
}