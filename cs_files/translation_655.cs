using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation655<T>
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
    
    public static TermStats[] GetHighFreqTerms(IndexReader reader, int numTerms, string field, IComparer<TermStats> comparer){
    TermStats[] terms = GetLowFreqTerms(reader, numTerms, field, comparer);
    if (terms.Length == 0){
        return null;
    }
    int highFreqCount = CountHighFrequencyTerms(terms, numTerms, field);
    var highFreqTerms = new List<TermStats>();
    for (int i = 0;
    i < terms.Length;
    i++){
        if (terms[i].Frequency > (numTerms * _threshold)){
            highFreqTerms.Add(terms[i]);
        }
    }
    highFreqTerms.Sort((x, y) => comparer.Compare(x, y));
    return highFreqTerms.ToArray();
}
}