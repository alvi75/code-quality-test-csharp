using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation521<T>
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
    
    public override void add(int location, E @object){
    if (location >= 0 && location <= _size){
        java.util.LinkedList.Link<E> link = voidLink;
        if (location < (_size / 2)){
            {
                for (int i = 0;
                i <= location;
                i++){
                    link = link.next;
                }
            }
        }
        else{
            {
                for (int i = _size;
                i > location;
                i--){
                    link = link.previous;
                }
            }
        }
        java.util.LinkedList.Link<E> previous = link.previous;
        java.util.LinkedList.Link<E> newLink = new java.util.LinkedList.Link<E>(@object, previous, link);
        previous.next = newLink;
        link.previous = newLink;
        _size++;
        modCount++;
    }
    else{
        throw new System.IndexOutOfRangeException();
    }
}
}