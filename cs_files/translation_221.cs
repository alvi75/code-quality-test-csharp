using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation221<T>
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
    
    public virtual string Stem(string word){
    var cmd = stemmer.GetLastOnPath(word);
    if (cmd == null){
        return null;
    }
    var builder = new StringBuilder(word.Length - cmd.Length);
    for (int i = 0;
    i < word.Length;
    i++){
        builder.Append(Char.ConvertFromUtf32(cmd.CodePointAt(i)));
    }
    return builder.ToString();
}
}