using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation731<T>
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
    
    public static WeightedTerm[] GetTerms(Query query, bool prohibited, string fieldName){
    var terms = new List<WeightedTerm>();
    var fieldQuery = new FieldQuery(query, prohibited, fieldName);
    var matcher = new MatchAllDocsQueryBuilder();
    matcher.SetQuery(fieldQuery);
    var weightedTerms = matcher.FindAll();
    foreach (var t in weightedTerms){
        terms.Add(t);
    }
    return terms.ToArray();
}
}