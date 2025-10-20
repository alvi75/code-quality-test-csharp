using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation233<T>
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
    
    public override Search.Query Build(IQueryNode queryNode){
    var andNode = (ANDQueryNode)queryNode;
    BooleanQuery bQuery = new BooleanQuery();
    IList<IQueryNode> children = andNode.GetChildren();
    if (children != null){
        foreach (IQueryNode child in children){
            object obj = child.GetTag(QueryTreeBuilder.QUERY_TREE_BUILDER_TAGID);
            if (obj != null){
                Query query = (Query)obj;
                try{
                    bQuery.Add(query, GetModifierValue(child));
                }
                catch (BooleanQuery.TooManyClausesException ex){
                    throw new QueryNodeException(new Message(QueryParserMessages.TOO_MANY_BOOLEAN_CLAUSES, BooleanQuery.MaxClauseCount, queryNode.ToQueryString(new EscapeQuerySyntax())), ex);
                }
            }
        }
    }
    bQuery.MinimumNumberShouldMatch = andNode.MinimumMatchingElements;
    if (andNode.IsBoosted){
        bQuery.Boost = andNode.Boost;
    }
    return bQuery;
}
}