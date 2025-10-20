using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation36<T>
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
    
    public ArrayPtg(Object[][] values2d){
    int nColumns = values2d.Length;
    int nRows = values2d[0].Length;
    _nColumns = (short)nColumns;
    _nRows = (short)nRows;
    Object[] vv = new Object[_nColumns * _nRows];
    for (int r = 0;
    r < nRows;
    r++){
        Object[] rowData = values2d[r];
        for (int c = 0;
        c < nColumns;
        c++){
            vv[GetValueIndex(c, r)] = rowData[c];
        }
    }
    _arrayValues = vv;
    _reserved0Int = 0;
    _reserved1Short = 0;
    _reserved2Byte = 0;
}
}