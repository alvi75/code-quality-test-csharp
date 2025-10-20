using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation872<T>
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
    
    public Status(IndexDiff diff){
    base(diff.Directory);
    this.diff = diff;
    hasUncommittedChanges = !diff.GetAdded().Count == 0 || !diff.GetChanged().Count == 0 || !diff.GetRemoved().Count == 0|| !diff.GetMissing().Count == 0;
    this.commit = null;
    this.workingTree = new File(diff.WorkingTree, IndexFileNames.SEGMENTS);
    this.index = new File(diff.IndexDirectory, IndexFileNames.SEGMENTS);
    this.meta = new File(diff.Directory, Constants.OBJECTS + IndexFileNames.SEGMENTS);
    this.pending = new PendingDelete(this.diff.GetDeltaCompress(), this.diff.GetMaxMergeSize(), this.diff.GetMaxMergeThreadCount());
}
}