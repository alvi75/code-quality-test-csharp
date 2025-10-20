using System;
using System.Collections.Generic;

public class Translation865<T>
{
    public virtual DescribeLagsResponse DescribeLags(DescribeLagsRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DescribeLagsRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DescribeLagsResponseUnmarshaller.Instance;
    return Invoke<DescribeLagsResponse>(request, options);
}
}