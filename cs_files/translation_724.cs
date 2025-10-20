using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation724<T>
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
    
    public override DiffEntry CompareTo(DiffEntry other){
    if (other == null){
        throw new ArgumentException("other must not be null");
    }
    if (this == other){
        return DiffEntry.NO_CHANGE;
    }
    int compare = CompareTo(other);
    if (compare < 0){
        return LessThan(other);
    }
    else if (compare > 0){
        return GreaterThan(other);
    }
    else{
        if (this.Boost == other.Boost){
            return CompareTo(other);
        }
        else{
            return this.Boost.CompareTo(other.Boost);
        }
    }
}
}