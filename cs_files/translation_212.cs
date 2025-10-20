using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation212<T>
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
    
    public static double Avedev(double[] v){
    double r = 0;
    double m = 0;
    double s = 0;
    for (int i = 0, iSize = v.Length;
    i < iSize;
    i++){
        s += v[i];
    }
    m = s / v.Length;
    for (int i = 0, iSize = v.Length;
    i < iSize;
    i++){
        s += Math.Abs(v[i] - m);
    }
    r = s / v.Length;
    return r;
}
}