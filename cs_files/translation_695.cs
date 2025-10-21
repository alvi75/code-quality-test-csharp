using System;
using System.Collections.Generic;

public class Translation695<T>
{
    public virtual GetContactReachabilityStatusResponse GetContactReachabilityStatus(GetContactReachabilityStatusRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = GetContactReachabilityStatusRequestMarshaller.Instance;
    options.ResponseUnmarshaller = GetContactReachabilityStatusResponseUnmarshaller.Instance;
    return Invoke<GetContactReachabilityStatusResponse>(request, options);
}
}