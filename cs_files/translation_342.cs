using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation342<T>
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
    
    public virtual void TrimToSize(){
    int s = _size;
    if (s == _array.Length){
        return;
    }
    if (s == 0){
        _array = libcore.util.EmptyArray.OBJECT;
    }
    else{
        object[] newArray = new object[s];
        System.Array.Copy(_array, 0, newArray, 0, s);
        _array = newArray;
    }
    modCount++;
}
}