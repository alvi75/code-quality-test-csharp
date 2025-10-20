using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation288<T>
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
    
    public override bool Equals(object @object){
    if (@object == this){
        return true;
    }
    if (@object is java.util.Set){
        java.util.Set<object> s = (java.util.Set<object>)@object;
        try{
            return _size == s.size() && _containsAll(s);
        }
        catch (System.NullReferenceException){
            return false;
        }
        catch (System.ArgumentException){
            return false;
        }
    }
    return false;
}
}