using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation753<T>
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
    
    public void RemoveSheet(int sheetIndex){
    if (boundsheets.Count > sheetIndex){
        records.Remove(records.Bspos - (boundsheets.Count - 1) + sheetIndex);
        boundsheets.RemoveAt(sheetIndex);
        FixTabIdRecord();
    }
    int sheetNum1Based = sheetIndex + 1;
    for (int i = 0;
    i < NumNames;
    i++){
        NameRecord nr = GetNameRecord(i);
        if (nr.SheetNumber == sheetNum1Based){
            nr.SheetNumber = 0;
        }
        else if (nr.SheetNumber > sheetNum1Based){
            nr.SheetNumber = nr.SheetNumber - 1;
        }
    }
    if (linkTable != null)linkTable.RemoveSheet(sheetIndex);
}
}