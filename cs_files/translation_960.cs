using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation960<T>
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
    
    public StandardQueryNodeProcessorPipeline(QueryConfigHandler queryConfig): base(queryConfig){
    Add(new WildcardQueryNodeProcessor());
    Add(new MultiFieldQueryNodeProcessor());
    Add(new FuzzyQueryNodeProcessor());
    Add(new RegexpQueryNodeProcessor());
    Add(new MatchAllDocsQueryNodeProcessor());
    Add(new OpenRangeQueryNodeProcessor());
    Add(new PointQueryNodeProcessor());
    Add(new PointRangeQueryNodeProcessor());
    Add(new TermRangeQueryNodeProcessor());
    Add(new AllowLeadingWildcardProcessor());
    Add(new AnalyzerQueryNodeProcessor());
    Add(new PhraseSlopQueryNodeProcessor());
    Add(new BooleanQuery2ModifierNodeProcessor());
    Add(new NoChildOptimizationQueryNodeProcessor());
    Add(new RemoveDeletedQueryNodesProcessor());
    Add(new RemoveEmptyNonLeafQueryNodeProcessor());
    Add(new BooleanSingleChildOptimizationQueryNodeProcessor());
    Add(new DefaultPhraseSlopQueryNodeProcessor());
    Add(new BoostQueryNodeProcessor());
    Add(new MultiTermQueryNodeProcessor());
    Add(new FieldQueryNodeProcessor());
    Add(new DistanceQueryNodeProcessor());
    Add(new SpanNotQueryNodeProcessor());
    Add(new SpanOrQueryNodeProcessor());
    Add(new SpanWithinQueryNodeProcessor());
    Add(new SpanFirstQueryNodeProcessor());
    Add(new SpanLastQueryNodeProcessor());
    Add(new SpanQueryNodeProcessor());
    Add(new GroupQueryNodeProcessor());
    Add(new HCenterQueryNodeProcessor());
    Add(new QueryTreeBuilder());
}
}