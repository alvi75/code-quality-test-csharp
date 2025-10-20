using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation942<T>
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
    
    public HashMap(int capacity, float loadFactor){
    this.capacity = capacity;
    this.loadFactor = loadFactor;
    if (capacity < 0 || capacity > int.MaxValue){
        throw new System.ArgumentException("Capacity: " + capacity);
    }
    if (float.IsNaN(loadFactor)){
        throw new System.ArgumentException("Load Factor: " + loadFactor);
    }
    if (capacity == 0 && float.IsNaN(loadFactor)){
        java.util.HashMap.HashMapEntry<K, V>[] tab = (java.util.HashMap.HashMapEntry<K, V>[])EMPTY_TABLE;
        table = tab;
        threshold = -1;
        return;
    }
    if (capacity < java.util.HashMap.MINIMUM_CAPACITY){
        capacity = java.util.HashMap.MINIMUM_CAPACITY;
    }
    else{
        if (capacity > java.util.HashMap.MAXIMUM_CAPACITY){
            capacity = java.util.HashMap.MAXIMUM_CAPACITY;
        }
        else{
            capacity = roundUpToPowerOfTwo(capacity);
        }
    }
    makeTable(capacity);
}
}