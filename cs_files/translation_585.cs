using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation585<T>
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
    
    public bool ProcessMatch(ValueEval eval){
    double result;
    try{
        result = OperandResolver.CoerceValueToDouble(eval);
        if (Double.IsNaN(result) || Double.IsInfinity(result)){
            throw new EvaluationException(ErrorEval.NUM_ERROR);
        }
        NumericFunction.CheckValue(result);
    }
    catch (EvaluationException e){
        return e.GetErrorEval();
    }
    return new NumberEval(result);
}
}