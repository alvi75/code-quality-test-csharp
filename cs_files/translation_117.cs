using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation117<T>
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
    
    public virtual SpanQuery MakeSpanClause(){
    SpanQuery[] spanQueries = new SpanQuery[Size];
    int i = 0;
    foreach (IQueryNode clause in m_clauses){
        if (clause is ISpanQuery){
            spanQueries[i++] = ((ISpanQuery)clause).MakeSpanQuery();
        }
        else{
            throw new QueryNodeException(clause.ToString()+ " is not a SpanQuery");
        }
    }
    if (spanQueries.Length == 1){
        return spanQueries[0];
    }
    else{
        return new OrQueryNode(spanQueries);
    }
}
}