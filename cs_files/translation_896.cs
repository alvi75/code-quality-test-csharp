using System;
using System.Collections.Generic;

public class Translation896<T>
{
    public virtual DeleteRouteResponseResponse DeleteRouteResponse(DeleteRouteResponseRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DeleteRouteResponseRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;
    return Invoke<DeleteRouteResponseResponse>(request, options);
}
}