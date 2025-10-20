using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation736<T>
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
    
    public override ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, ValueEval arg0, ValueEval arg1){
    try{
        AreaEval reA = EvaluateRef(arg0);
        AreaEval reB = EvaluateRef(arg1);
        AreaEval result = ResolveRange(reA, reB);
        if (result == null){
            return ErrorEval.VALUE_INVALID;
        }
        return result;
    }
    catch (EvaluationException e){
        return e.GetErrorEval();
    }
}
}