using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation310<T>
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
    
    public virtual bool IsExpectedToken(int symbol){
    ATN atn = Interpreter.atn;
    ParserRuleContext ctx = _ctx;
    ATNState s = atn.states[State];
    IntervalSet following = atn.NextTokens(s);
    if (following.Contains(symbol)){
        return true;
    }
    if (!following.Contains(TokenConstants.EPSILON)){
        return false;
    }
    while (ctx != null && ctx.invokingState >= 0 && following.Contains(TokenConstants.EPSILON)){
        ATNState invokingState = atn.states[ctx.invokingState];
        RuleTransition rt = (RuleTransition)invokingState.Transition(0);
        following = atn.NextTokens(rt.followState);
        if (following.Contains(symbol)){
            return true;
        }
        ctx = (ParserRuleContext)ctx.Parent;
    }
    if (following.Contains(TokenConstants.EPSILON) && symbol == IntStreamConstants.EOF){
        return true;
    }
    return false;
}
}