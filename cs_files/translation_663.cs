using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation663<T>
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
    
    public static PredictionContext FromRuleContext(ParserRuleContext atn, RuleContext outerContext){
    if (outerContext == null){
        outerContext = RuleContext.EMPTY;
    }
    PredictionContext parent = outerContext;
    parent = PredictionContext.FromRuleContext(atn, outerContext.Parent);
    ATNState state = atn.states[outerContext.invokingState];
    RuleTransition transition = (RuleTransition)state.Transition(0);
    return SingletonPredictionContext.Create(parent, transition.followState);
}
}