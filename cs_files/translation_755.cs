using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation755<T>
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
    
    public override bool Equals(object o){
    if (!(o is Property)){
        return false;
    }
    Property p = (Property)o;
    Object pValue = p.Value;
    long pId = p.ID;
    if (id != pId || (id != 0 && !TypesAreEqual(type, p.Type))){
        return false;
    }
    if (value == null && pValue == null){
        return true;
    }
    if (value == null || pValue == null){
        return false;
    }
    Type a = value.GetType();
    Type b = pValue.GetType();
    if (!a.Equals(b)){
        return false;
    }
    if (value is byte[]){
        byte[] thisVal = (byte[])value;
        byte[] otherVal = pValue;
        int len = UnpaddedLength(thisVal);
        if (len != UnpaddedLength(otherVal)){
            return false;
        }
        for (int i = 0;
        i < len;
        i++){
            if (thisVal[i] != otherVal[i]){
                return false;
            }
        }
        return true;
    }
    return value.Equals(pValue);
}
}