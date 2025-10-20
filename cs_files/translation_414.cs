using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation414<T>
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
    
    public virtual int lastIndexOf(object @object){
    int pos = _size;
    java.util.LinkedList.Link<E> link = voidLink.previous;
    if (@object != null){
        while (link != voidLink){
            pos--;
            if (@object.Equals(link.data)){
                return pos;
            }
            link = link.previous;
        }
    }
    else{
        while (link != voidLink){
            pos--;
            if ((object)link.data == null){
                return pos;
            }
            link = link.previous;
        }
    }
    return -1;
}
}