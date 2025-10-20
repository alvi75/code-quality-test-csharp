using System;
using System.Collections.Generic;

public class Translation429<T>
{
    public virtual RestoreDBClusterToPointInTimeResponse RestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
    options.ResponseUnmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;
    return Invoke<RestoreDBClusterToPointInTimeResponse>(request, options);
}
}