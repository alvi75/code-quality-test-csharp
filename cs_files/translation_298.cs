using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation298<T>
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
    
    public static float[] Grow(float[] array, int minSize){
    Debug.Assert(minSize >= 0, "size must be positive (got " + minSize + "): likely integer overflow?");
    if (array.Length < minSize){
        float[] newArray = new float[Oversize(minSize, RamUsageEstimator.NUM_BYTES_SINGLE)];
        Array.Copy(array, 0, newArray, 0, array.Length);
        return newArray;
    }
    else{
        return array;
    }
}
}