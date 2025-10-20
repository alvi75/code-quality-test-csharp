using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation405<T>
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
    
    public override int Following(int pos){
    if (pos < text.BeginIndex || pos > text.EndIndex){
        throw new ArgumentException("offset out of bounds");
    }
    else if (0 == sentenceStarts.Length){
        text.SetIndex(text.BeginIndex);
        currentSentence = 0;
        return Done;
    }
    else if (pos >= sentenceStarts[sentenceStarts.Length - 1]){
        text.SetIndex(text.EndIndex);
        currentSentence = sentenceStarts.Length - 1;
        return Done;
    }
    else{
        currentSentence = sentenceStarts.Length / 2;
        ToSentenceAt(pos, 0, sentenceStarts.Length - 2);
        text.SetIndex(sentenceStarts[++currentSentence]);
        return Current;
    }
}
}