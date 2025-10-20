using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation759<T>
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
    
    public override void Close(){
    if (outerInstance.read(p, 0, Constants.OBJECT_ID_LENGTH) != -1 || @in.GetFilePointer() != @in.GetSize()){
        throw new CorruptObjectException(MessageFormat.Format(JGitText.Get().packfileCorruptionDetected, JGitText.Get().wrongDecompressedLength));
    }
    int used2;
    if (outerInstance.sizeIncludesHeaderSize){
        used2 = p + Constants.OBJECT_ID_LENGTH;
    }
    else{
        used2 = p + Constants.OBJECT_ID_LENGTH + @in.GetFilePointer();
    }
    outerInstance.Use(p, used2);
}
}
}