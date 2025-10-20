using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation182<T>
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
    
    public static double Devsq(double[] v){
    double r = double.NaN;
    if (v != null && v.Length >= 1){
        double m = 0;
        double s = 0;
        int n = v.Length;
        for (int i = 0;
        i < n;
        i++){
            s += v[i];
        }
        m = s / n;
        for (int i = 0;
        i < n;
        i++){
            s += (v[i] - m) * (v[i] - m);
        }
        r = (n == 1) ? 0 : s;
    }
    return r;
}
}