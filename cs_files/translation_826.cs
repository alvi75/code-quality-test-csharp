using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation826<T>
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
    
    public QueryScorer(WeightedSpanTerm[] weightedTerms){
    this.fieldWeightedSpanTerms = new Dictionary<string, WeightedSpanTerm>();
    for (int i = 0;
    i < weightedTerms.Length;
    i++){
        if (!fieldWeightedSpanTerms.TryGetValue(weightedTerms[i].Field, out WeightedSpanTerm existingTerm)|| (existingTerm == null)|| (existingTerm.Weight < weightedTerms[i].Weight)){
            fieldWeightedSpanTerms[weightedTerms[i].Field] = weightedTerms[i];
            maxTermWeight = Math.Max(maxTermWeight, weightedTerms[i].Weight);
        }
    }
}
}