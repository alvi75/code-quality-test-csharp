using System;
using System.Collections.Generic;

public class Translation710<T>
{
    public BloomFilteringPostingsFormat(PostingsFormat @delegatePostingsFormat, BloomFilterFactory bloomFilterFactory){
    this.@delegatePostingsFormat = @delegatePostingsFormat;
    this.bloomFilterFactory = bloomFilterFactory;
}
}