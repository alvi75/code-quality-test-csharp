using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation371<T>
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
    
    public override string ToString(){
    var children = GetChildren();
    if (children == null || children.Count == 0)return "<boolean operation='or'/>";
    StringBuilder sb = new StringBuilder();
    sb.Append("<boolean operation='or'>");
    foreach (IQueryNode child in children){
        sb.Append("\n");
        sb.Append(child.ToString());
    }
    sb.Append("\n</boolean>");
    return sb.ToString();
}
}