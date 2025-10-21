using System;
using System.Collections.Generic;

public class Translation81<T>
{
    public virtual DescribeVoicesResponse DescribeVoices(DescribeVoicesRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DescribeVoicesRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DescribeVoicesResponseUnmarshaller.Instance;
    return Invoke<DescribeVoicesResponse>(request, options);
}
}