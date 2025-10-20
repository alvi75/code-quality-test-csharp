using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation176<T>
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
    
    public WindowOneRecord(RecordInputStream in1){
    field_1_hHold = in1.ReadShort();
    field_2_vHold = in1.ReadShort();
    field_3_width = in1.ReadShort();
    field_4_height = in1.ReadShort();
    field_5_options = in1.ReadShort();
    field_6_activeTab = in1.ReadShort();
    field_7_firstVisibleTab = in1.ReadShort();
    field_8_numSelectedTabs = in1.ReadShort();
    field_9_tabWidthRatio = in1.ReadShort();
}
}