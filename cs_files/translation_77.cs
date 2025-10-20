using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation77<T>
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
    
    public virtual string GetHumanishName(){
    string s = Path;
    if (s.Length == 0){
        s = GetType().FullName;
    }
    int idx = s.LastIndexOf('.');
    if (idx == -1){
        return s;
    }
    string name = s.Substring(idx + 1, s.Length - (idx + 1));
    s = s.Substring(0, idx);
    return $"{
        s}
        .{
            name}
            ";
        }
}