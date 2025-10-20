using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation570<T>
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
    
    public override ValueEval Evaluate(ValueEval[] args, OperationEvaluationContext ec){
    if (args.Length < 1){
        return ErrorEval.VALUE_INVALID;
    }
    bool isA1style;
    String text;
    try{
        ValueEval ve = OperandResolver.GetSingleValue(args[0], ec.RowIndex, ec.ColumnIndex);
        text = OperandResolver.CoerceValueToString(ve);
        switch (args.Length){
            case 1:isA1style = true;
            break;
            case 2:isA1style = EvaluateBooleanArg(args[1], ec);
            break;
            default:return ErrorEval.VALUE_INVALID;
        }
    }
    catch (EvaluationException e){
        return e.GetErrorEval();
    }
    return EvaluateIndirect(ec, text, isA1style);
}
}