using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation51<T>
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
    
    public IList<CharsRef> UniqueStems(char[] word, int length){
    IList<CharsRef> stems = Stem(word, length);
    if (stems.Count < 2){
        return stems;
    }
    var terms = new CharArraySet(8, dictionary);
    IList<CharsRef> deduped = new List<CharsRef>();
    foreach (var stem in stems){
        if (!terms.Contains(stem)){
            deduped.Add(stem);
            terms.Add(stem);
        }
    }
    return deduped;
}
}