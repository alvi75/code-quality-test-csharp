using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation7<T>
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
    
    public POIFSFileSystem(){
    this(true);
    _header.BATCount = 1;
    _header.BATArray = new int[1];
    _bat_block = new BATBlock();
    _bat_block.SetBlockType(BATBlock.BAT_TYPE_FAT);
    _bat_block.AddProperty(new Property(PropertyIDMap.PID_FAT));
    _sbat_block = new SBABlock();
    _sbat_block.SetBlockType(BATBlock.BAT_TYPE_SBA);
    _sbat_block.AddProperty(new Property(PropertyIDMap.PID_SBA));
}
}