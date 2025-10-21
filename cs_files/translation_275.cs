using System;
using System.Collections.Generic;

public class Translation275<T>
{
    public virtual DescribeCodeRepositoryResponse DescribeCodeRepository(DescribeCodeRepositoryRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DescribeCodeRepositoryRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DescribeCodeRepositoryResponseUnmarshaller.Instance;
    return Invoke<DescribeCodeRepositoryResponse>(request, options);
}
}