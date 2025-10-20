using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation369<T>
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
    
    public static double kthSmallest(double[] v, int k){
    double r = double.NaN;
    k--;
    if (v != null && v.Length > k && k >= 0){
        Array.Sort(v);
        r = v[k];
    }
    return r;
}
}