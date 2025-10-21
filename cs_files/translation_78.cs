using System;
using System.Collections.Generic;

public class Translation78<T>
{
    public virtual DescribeNotebookInstanceLifecycleConfigResponse DescribeNotebookInstanceLifecycleConfig(DescribeNotebookInstanceLifecycleConfigRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DescribeNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DescribeNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;
    return Invoke<DescribeNotebookInstanceLifecycleConfigResponse>(request, options);
}
}