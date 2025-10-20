using System;
using System.Collections.Generic;

public class Translation336<T>
{
    public virtual DescribeServiceUpdatesResponse DescribeServiceUpdates(DescribeServiceUpdatesRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DescribeServiceUpdatesRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DescribeServiceUpdatesResponseUnmarshaller.Instance;
    return Invoke<DescribeServiceUpdatesResponse>(request, options);
}
}