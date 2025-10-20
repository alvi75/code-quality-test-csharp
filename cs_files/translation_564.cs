using System;
using System.Collections.Generic;

public class Translation564<T>
{
    public virtual DeleteAppResponse DeleteApp(DeleteAppRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;
    return Invoke<DeleteAppResponse>(request, options);
}
}