using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation43<T>
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
    
    public void MultiplyByPowerOfTen(int pow10){
    int x = pow10;
    if (x < 0){
        _significand = _significand.Substring(1);
        x = -1;
    }
    if (x > 20){
        throw new InvalidOperationException("Too many binary digits for pow10=" + x + ". Max is 20");
    }
    _binaryExponent += x;
    _significand = Rounder.Round(_significand, x);
    if (_significand.BitLength() > 64){
        int extra = 64 - _significand.BitLength();
        _significand = _significand.Add(extra);
        x++;
    }
    _significand = _significand.Substring(1);
}
}