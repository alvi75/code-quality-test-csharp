using System;
using System.Collections.Generic;

public class Translation177<T>
{
    public virtual StopWorkspacesResponse StopWorkspaces(StopWorkspacesRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = StopWorkspacesRequestMarshaller.Instance;
    options.ResponseUnmarshaller = StopWorkspacesResponseUnmarshaller.Instance;
    return Invoke<StopWorkspacesResponse>(request, options);
}
}