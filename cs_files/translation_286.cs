using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation286<T>
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
    
    public override bool Equals(Object obj){
    if (this == obj){
        return true;
    }
    if (obj == null){
        return false;
    }
    if (obj is HSSFCellStyle){
        HSSFCellStyle other = (HSSFCellStyle)obj;
        if (_format == null){
            if (other._format != null){
                return false;
            }
        }
        else if (!_format.Equals(other._format)){
            return false;
        }
        if (_index != other._index){
            return false;
        }
        return true;
    }
    return false;
}
}