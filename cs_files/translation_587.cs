using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation587<T>
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
    
    public static void Main(string[] args){
    bool printTree = false;
    string path = null;
    for (int i = 0;
    i < args.Length;
    i++){
        if (args[i].Equals("-printTree", StringComparison.Ordinal)){
            printTree = true;
        }
        else{
            path = args[i];
        }
    }
    if (args.Length != (printTree ? 2 : 1)){
        throw new ArgumentException();
    }
    Directory dir = FSDirectory.Open(new DirectoryInfo(path));
    ITaxonomyReader r = new DirectoryTaxonomyReader(dir);
    PrintStats(r, Console.Out, printTree);
    r.Dispose();
    dir.Dispose();
}
}