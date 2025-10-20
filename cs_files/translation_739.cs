using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation739<T>
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
    
    public SrndQuery PrimaryQuery(){
    SrndQuery q;
    switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk){
        case RegexpToken.LPAREN:Jj_consume_token(RegexpToken.LPAREN);
        q = FieldsQuery();
        Jj_consume_token(RegexpToken.RPAREN);
        break;
        case RegexpToken.OR:case RegexpToken.AND:case RegexpToken.W:case RegexpToken.N:q = PrefixOperatorQuery();
        break;
        case RegexpToken.TERM:case RegexpToken.REGEXPTERM:case RegexpToken.RANGEIN_START:case RegexpToken.RANGEEX_START:case RegexpToken.NUMBER:;
        break;
        default:jj_la1[6] = jj_gen;
        Jj_consume_token(-1);
        throw new ParseException();
    }
    OptimizeQuery(q);
    return q;
}
}