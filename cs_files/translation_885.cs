using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation885<T>
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
    
    public virtual RevCommit TryFastForward(RevCommit newCommit){
    if (newCommit == null){
        throw new ArgumentNullException("newCommit");
    }
    if (newCommit.IsComplete){
        throw new ArgumentException(JGitText.Get().alreadyCompleteCommit);
    }
    RefCounted<RevCommit> @ref = refCount.GetAndIncrement();
    try{
        AddCommand(command);
        if (@ref.IsValueCreated && @ref.Value != null){
            return @ref.Value;
        }
        else{
            ClearCommand();
            return null;
        }
    }
    catch (IOException ioe){
        ClearCommand();
        throw;
    }
}
}